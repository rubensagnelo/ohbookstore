using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ohbookstore.Application.Boundaries;
using ohbookstore.Domain;

namespace ohbookstore.Application.UseCases
{
	public class RemoverLivroDoCarrinhoUseCase : Boundaries.IRemoverLivroCarrinhoUseCase
	{

		private readonly ICarrinhoRepository _CarrinhoRepository;
		private readonly CarrinhoService _CarrinhoService;
		private readonly IRemoverLivroCarrinhoSaidaPort _RemoverLivroCarrinhoSaidaPort;
		private readonly IUnitOfWork _unitOfWork;

		public RemoverLivroDoCarrinhoUseCase(
			ICarrinhoRepository CarrinhoRepository, 
			CarrinhoService CarrinhoService, 
			IRemoverLivroCarrinhoSaidaPort RemoverLivroCarrinhoSaidaPort, 
			IUnitOfWork unitOfWork)
		{
			_CarrinhoRepository = CarrinhoRepository;
			_CarrinhoService = CarrinhoService;
			_RemoverLivroCarrinhoSaidaPort = RemoverLivroCarrinhoSaidaPort;
			_unitOfWork = unitOfWork;
		}

		public async Task Executar(RemoverLivroCarrinhoEntrada entrada)
		{
			if (entrada is null)
			{
				this._RemoverLivroCarrinhoSaidaPort.WriteError("Entrada não pode ser nula");
				return;
			}

			ICarrinhoLivro CarrinhoLivro = await this._CarrinhoRepository.GetCarrinhoLivro().ConfigureAwait(false);

			if (CarrinhoLivro is null)
			{
				this._RemoverLivroCarrinhoSaidaPort.WriteError("Cadastro de livros não existe.");
				return;
			}


			ILivro livro = await this._CarrinhoService.RemoverLivroDoCarrinho(CarrinhoLivro, entrada.Carrinho, entrada.Livro); 


			await this._unitOfWork.Save().ConfigureAwait(false);

			this.BuildOutput(livro);
		}

		private void BuildOutput(ILivro livro)
		{
			Livro Livro = (Livro)livro;
			var output = new RemoverLivroCarrinhoSaida(Livro);
			this._RemoverLivroCarrinhoSaidaPort.Standard(output);
		}
	}
}
