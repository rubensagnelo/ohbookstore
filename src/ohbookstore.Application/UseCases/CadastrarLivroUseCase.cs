using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ohbookstore.Application.Boundaries;
using ohbookstore.Domain;

namespace ohbookstore.Application.UseCases
{
	public sealed class CadastrarLivroUseCase : Boundaries.ICadastrarLivroUseCase
	{

		private readonly ICadastroLivroRepository _CadastroLivroRepository;
		private readonly CadastroLivroService _CadastroLivroService;
		private readonly ICadastrarLivroSaidaPort _CadastrarLivroSaidaPort;
		private readonly IUnitOfWork _unitOfWork;

		public CadastrarLivroUseCase(
			ICadastroLivroRepository CadastroLivroRepository, 
			CadastroLivroService CadastroLivroService, 
			ICadastrarLivroSaidaPort CadastrarLivroSaidaPort, 
			IUnitOfWork unitOfWork)
		{
			_CadastroLivroRepository = CadastroLivroRepository;
			_CadastroLivroService = CadastroLivroService;
			_CadastrarLivroSaidaPort = CadastrarLivroSaidaPort;
			_unitOfWork = unitOfWork;
		}


		public async Task Executar(CadastrarLivroEntrada entrada)
		{

			if (entrada is null)
			{
				this._CadastrarLivroSaidaPort.WriteError("Entrada não pode ser nula");
				return;
			}

			ICadastroLivro CadastroLivro = await this._CadastroLivroRepository.GetCadastroLivro().ConfigureAwait(false);

			if (CadastroLivro is null)
			{
				this._CadastrarLivroSaidaPort.WriteError("Cadastro de livros não existe.");
				return;
			}


			ILivro livro = await this._CadastroLivroService.CadastrarLivro(CadastroLivro,
				new Livro()
				{
					autor = entrada.autor,
					isbn = entrada.isbn,
					nome = entrada.nome,
					preco = entrada.preco
				});


			await this._unitOfWork.Save().ConfigureAwait(false);

			this.BuildOutput(livro.isbn.id);
		}

		private void BuildOutput(string iSBN)
		{
			var output = new CadastrarLivroSaida(iSBN);
			this._CadastrarLivroSaidaPort.Standard(output);
		}
	}
}
