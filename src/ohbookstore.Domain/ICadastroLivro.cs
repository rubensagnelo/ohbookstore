using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Domain
{
	public interface ICadastroLivro
	{

		ILivro IncluirLivro(ICadastroLivroFactory eitidadeFactory, Livro Livro);
		bool ExcluirLivro(ICadastroLivroFactory eitidadeFactory, Livro Livro);
		ILivro ALterarLivro(ICadastroLivroFactory eitidadeFactory, Livro Livro);
		ILivros GetLivros(ICadastroLivroFactory eitidadeFactory, int IdCadastro);


	}
}
