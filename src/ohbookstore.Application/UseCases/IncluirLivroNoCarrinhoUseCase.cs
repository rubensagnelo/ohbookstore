using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ohbookstore.Application.Boundaries;
using ohbookstore.Domain;

namespace ohbookstore.Application.UseCases
{
	public class IncluirLivroNoCarrinhoUseCase : Boundaries.IIncluirLivroCarrinhoUseCase
	{
		private readonly ICarrinhoRepository _CarrinhoRepository;
		private readonly CarrinhoService _CarrinhoService;
		private readonly IIncluirLivroCarrinhoSaidaPort _IncluirLivroCarrinhoSaidaPort;
		private readonly IUnitOfWork _unitOfWork;

		public IncluirLivroNoCarrinhoUseCase(
			ICarrinhoRepository CarrinhoRepository, 
			CarrinhoService CarrinhoService, 
			IIncluirLivroCarrinhoSaidaPort IncluirLivroCarrinhoSaidaPort, 
			IUnitOfWork unitOfWork)
		{
			_CarrinhoRepository = CarrinhoRepository;
			_CarrinhoService = CarrinhoService;
			_IncluirLivroCarrinhoSaidaPort = IncluirLivroCarrinhoSaidaPort;
			_unitOfWork = unitOfWork;
		}


		public async Task Executar(IncluirLivroCarrinhoEntrada entrada)
		{
			if (entrada is null)
			{
				this._IncluirLivroCarrinhoSaidaPort.WriteError("Entrada não pode ser nula");
				return;
			}

			ICarrinhoLivro CarrinhoLivro = await this._CarrinhoRepository.GetCarrinhoLivro().ConfigureAwait(false);

			if (CarrinhoLivro is null)
			{
				this._IncluirLivroCarrinhoSaidaPort.WriteError("Carrinho não existe.");
				return;
			}

			ILivro livro = await this._CarrinhoService.IncluirLivroNoCarrinho(CarrinhoLivro, entrada.Carrinho, entrada.Livro);


			await this._unitOfWork.Save().ConfigureAwait(false);

			this.BuildOutput(livro);
		}

		private void BuildOutput(ILivro livro)
		{
			Livro Livro = (Livro)livro;
			var output = new IncluirLivroCarrinhoSaida(Livro);
			this._IncluirLivroCarrinhoSaidaPort.Standard(output);
		}

	}
}
