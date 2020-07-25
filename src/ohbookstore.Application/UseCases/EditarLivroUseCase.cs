using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ohbookstore.Application.Boundaries;
using ohbookstore.Domain;


namespace ohbookstore.Application.UseCases
{
	public class EditarLivroUseCase : Boundaries.IEditarLivroUseCase
	{
		private readonly ICadastroLivroRepository _CadastroLivroRepository;
		private readonly CadastroLivroService _CadastroLivroService;
		private readonly IEditarLivroSaidaPort _EditarLivroSaidaPort;
		private readonly IUnitOfWork _unitOfWork;


		public async Task Executar(EditarLivroEntrada entrada)
		{
			if (entrada is null)
			{
				this._EditarLivroSaidaPort.WriteError("Entrada não pode ser nula");
				return;
			}

			ICadastroLivro CadastroLivro = await this._CadastroLivroRepository.GetCadastroLivro().ConfigureAwait(false);

			if (CadastroLivro is null)
			{
				this._EditarLivroSaidaPort.WriteError("Cadastro de livros não existe.");
				return;
			}


			ILivro livro = await this._CadastroLivroService.AlterarLivro(CadastroLivro,
				new Livro()
				{
					isbn = entrada.isbn,
					autor = entrada.autor,
					nome = entrada.nome,
					preco = entrada.preco
				});


			await this._unitOfWork.Save().ConfigureAwait(false);

			this.BuildOutput(livro.isbn.id);
		}

		private void BuildOutput(string iSBN)
		{
			var output = new EditarLivroSaida(iSBN);
			this._EditarLivroSaidaPort.Standard(output);
		}

	}
}
