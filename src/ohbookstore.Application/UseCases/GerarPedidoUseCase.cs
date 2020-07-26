using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ohbookstore.Application.Boundaries;
using ohbookstore.Domain;

namespace ohbookstore.Application.UseCases
{
	public class GerarPedidoUseCase : Boundaries.IGerarPedidoUseCase
	{
		private readonly ICarrinhoRepository _CarrinhoRepository;
		private readonly CarrinhoService _CarrinhoService;
		private readonly IGerarPedidoSaidaPort _GerarPedidoSaidaPort;
		private readonly IUnitOfWork _unitOfWork;

		public GerarPedidoUseCase(
			ICarrinhoRepository CarrinhoRepository, 
			CarrinhoService CarrinhoService, 
			IGerarPedidoSaidaPort GerarPedidoSaidaPort, 
			IUnitOfWork unitOfWork)
		{
			_CarrinhoRepository = CarrinhoRepository;
			_CarrinhoService = CarrinhoService;
			_GerarPedidoSaidaPort = GerarPedidoSaidaPort;
			_unitOfWork = unitOfWork;
		}


		public async Task Executar(GerarPedidoEntrada entrada)
		{
			if (entrada is null)
			{
				this._GerarPedidoSaidaPort.WriteError("Entrada não pode ser nula");
				return;
			}

			ICarrinhoLivro CarrinhoLivro = await this._CarrinhoRepository.GetCarrinhoLivro().ConfigureAwait(false);

			if (CarrinhoLivro is null)
			{
				this._GerarPedidoSaidaPort.WriteError("Carrinho não existe.");
				return;
			}

			IPedido pedido = await this._CarrinhoService.GerarPedido(CarrinhoLivro, entrada.livros, entrada.Cliente);


			await this._unitOfWork.Save().ConfigureAwait(false);

			this.BuildOutput(pedido);
		}

		private void BuildOutput(IPedido pedido)
		{
			Pedido Pedido = (Pedido)pedido;
			var output = new GerarPedidoSaida(Pedido);
			this._GerarPedidoSaidaPort.Standard(output);
		}
	}
}
