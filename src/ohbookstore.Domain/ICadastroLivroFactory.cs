using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Domain
{
	public interface ICadastroLivroFactory
	{
		ICadastroLivro NovoCadastroLivros(Int32 idcadastroLivro);
		ILivro NovoLivro(ICadastroLivro cadastrolivro, Livro livro);
		bool RemoveLivro(ICadastroLivro cadastrolivro, string isbn);
		bool AlterarLivro(ICadastroLivro cadastrolivro, Livro livro);

	}
}
