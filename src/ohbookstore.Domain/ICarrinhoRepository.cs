using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ohbookstore.Domain
{
	public interface ICarrinhoRepository
	{
		Task Add(ICarrinho carrinho);
		Task Delete(ICarrinho carrinho);

		Task AddLivro(ICarrinho carrinho, ILivro livro);
		Task DeleteLivro(ICadastroLivro CadastroLivro, ILivro livro);

	}
}
