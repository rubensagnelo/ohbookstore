using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace ohbookstore.Domain
{
	public interface ICadastroLivroRepository
	{
		Task<ICadastroLivro> GetCadastroLivro();
		Task Add(ICadastroLivro CadastroLivro, ILivro livro);
		Task Update(ICadastroLivro CadastroLivro, ILivro livro);
		Task Delete(ICadastroLivro CadastroLivro, ILivro livro);
	}
}
