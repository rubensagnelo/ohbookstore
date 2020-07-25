using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Domain
{
	public interface ICadastroLivro
	{

		ILivro IncluirLivro(ICadastroLivroFactory entidadeFactory, Livro Livro);
		bool ExcluirLivro(ICadastroLivroFactory entidadeFactory, Livro Livro);
		ILivro ALterarLivro(ICadastroLivroFactory entidadeFactory, Livro Livro);
		ILivros GetLivros(ICadastroLivroFactory entidadeFactory, int IdCadastro);


	}
}
