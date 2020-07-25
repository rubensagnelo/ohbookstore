using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Domain
{
	public abstract class CadastroLivro : ICadastroLivro
	{
		public abstract Livros Livros { get; }
		public abstract Int32 Id { get; }


		public ILivro ALterarLivro(ICadastroLivroFactory entidadeFactory, Livro Livro)
		{
			if (entidadeFactory is null)
			{
				throw new ArgumentNullException(nameof(entidadeFactory));
			}

			ILivro livro = entidadeFactory.NovoLivro(this, Livro);
			Livros.Add(livro);
			return livro;
		}

		public bool ExcluirLivro(ICadastroLivroFactory entidadeFactory, Livro Livro)
		{
			bool result = false;

			if (entidadeFactory is null)
			{
				throw new ArgumentNullException(nameof(entidadeFactory));
			}

			 ILivro livro = Livros.Find(x => x.isbn.Equals(Livro.isbn));

			if (livro is null)
			{
				throw new ArgumentNullException(nameof(livro));
			}


			//result = entidadeFactory.RemoveLivro(this, Livro)
			 //if (result)
				Livros.Remove(livro);

			return result;
		}

		public ILivros GetLivros(ICadastroLivroFactory eitidadeFactory, Livro Livro)
		{
			throw new NotImplementedException();
		}

		public ILivros GetLivros(ICadastroLivroFactory eitidadeFactory, int IdCadastro)
		{
			throw new NotImplementedException();
		}

		public ILivro IncluirLivro(ICadastroLivroFactory eitidadeFactory, Livro Livro)
		{
			throw new NotImplementedException();
		}
	}
}
