using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ohbookstore.Domain
{
	public interface ICarrinhoRepository
	{
		Task Add(ICarrinho carrinho);
		Task Remover(ICarrinho carrinho);

		Task Add(ICarrinho carrinho, ILivro livro);
		Task Delete(ICadastroLivro CadastroLivro, ILivro livro);

	}
}
