using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ohbookstore.Application.Boundaries;
using ohbookstore.Domain;


namespace ohbookstore.Application.UseCases
{
	public class ExcluirLivroUseCase : Boundaries.IExcluirLivroUseCase
	{

		private readonly ICadastroLivroRepository _CadastroLivroRepository;
		private readonly CadastroLivroService _CadastroLivroService;
		private readonly IExcluirLivroSaidaPort _ExcluirLivroSaidaPort;
		private readonly IUnitOfWork _unitOfWork;


		public ExcluirLivroUseCase(
			ICadastroLivroRepository CadastroLivroRepository, 
			CadastroLivroService CadastroLivroService, 
			IExcluirLivroSaidaPort ExcluirLivroSaidaPort, 
			IUnitOfWork unitOfWork)
		{
			_CadastroLivroRepository = CadastroLivroRepository;
			_CadastroLivroService = CadastroLivroService;
			_ExcluirLivroSaidaPort = ExcluirLivroSaidaPort;
			_unitOfWork = unitOfWork;
		}

		public async Task Executar(ExcluirLivroEntrada entrada)
		{

			if (entrada is null)
			{
				this._ExcluirLivroSaidaPort.WriteError("Entrada não pode ser nula");
				return;
			}

			ICadastroLivro CadastroLivro = await this._CadastroLivroRepository.GetCadastroLivro().ConfigureAwait(false);

			if (CadastroLivro is null)
			{
				this._ExcluirLivroSaidaPort.WriteError("Cadastro de livros não existe.");
				return;
			}


			ILivro livro = await this._CadastroLivroService.ExcluirLivro(CadastroLivro,
				new Livro()
				{
					isbn = entrada.isbn,
				});


			await this._unitOfWork.Save().ConfigureAwait(false);

			this.BuildOutput(livro.isbn.id);
		}

		private void BuildOutput(string iSBN)
		{
			var output = new ExcluirLivroSaida(iSBN);
			this._ExcluirLivroSaidaPort.Standard(output);
		}
	}
	
}
