using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace ohbookstore.Domain
{
	public interface ICadastroLivroRepository
	{
		Task<ILivro> GetLivro(string isbnID);
		Task<ILivro> GetBy(ISBN isbn);
		Task Add(ILivro livro);
		Task Update(ILivro livro);
		Task Delete(ILivro livro);
	}
}
