using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ohbookstore.Domain
{
	public sealed class CadastroLivroService
	{
		private readonly ICadastroLivroFactory _CadastroLivroFactory;
		private readonly ICadastroLivroRepository _CadastroLivroRepository;

		public CadastroLivroService(ICadastroLivroFactory CadastroLivroFactory, ICadastroLivroRepository CadastroLivroRepository)
		{
			_CadastroLivroFactory = CadastroLivroFactory;
			_CadastroLivroRepository = CadastroLivroRepository;
		}


		public async Task<ILivro> CadastrarLivro(ICadastroLivro CadastroLivro, Livro Livro)
		{
			if (CadastroLivro is null)
			{
				throw new ArgumentNullException(nameof(CadastroLivro));
			}

			if (Livro is null)
			{
				throw new ArgumentNullException(nameof(Livro));
			}

			ILivro livro = CadastroLivro.IncluirLivro(this._CadastroLivroFactory, Livro);
			await this._CadastroLivroRepository.Add(CadastroLivro, livro)
				.ConfigureAwait(false);

			return livro;
		}

		public async Task<ILivro> EcluirLivro(ICadastroLivro CadastroLivro, Livro Livro)
		{
			if (CadastroLivro is null)
			{
				throw new ArgumentNullException(nameof(CadastroLivro));
			}

			if (Livro is null)
			{
				throw new ArgumentNullException(nameof(Livro));
			}


			bool result = false;

			result = CadastroLivro.ExcluirLivro(this._CadastroLivroFactory, Livro);
			ILivro livro = (ILivro)Livro;
			await this._CadastroLivroRepository.Delete(CadastroLivro, livro)
				.ConfigureAwait(false);

			return livro;
		}



		public async Task<ILivro> Alterar(ICadastroLivro CadastroLivro, Livro Livro)
		{
			if (CadastroLivro is null)
			{
				throw new ArgumentNullException(nameof(CadastroLivro));
			}

			if (Livro is null)
			{
				throw new ArgumentNullException(nameof(Livro));
			}

			ILivro livro = CadastroLivro.ALterarLivro(this._CadastroLivroFactory, Livro);
			if (livro != null)
				await this._CadastroLivroRepository.Update(CadastroLivro, livro).ConfigureAwait(false);

			return livro;
		}



	}
}
