using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ohbookstore.Domain
{
	public interface ICarrinhoRepository
	{
		Task<ICarrinhoLivro> GetCarrinhoLivro();

		Task Add(ICarrinhoLivro CarrinhoLivro, ICarrinho carrinho);
		Task Delete(ICarrinhoLivro CarrinhoLivro, ICarrinho carrinho);

		Task AddLivro(ICarrinhoLivro CarrinhoLivro, ICarrinho carrinho, ILivro livro);
		Task DeleteLivro(ICarrinhoLivro CarrinhoLivro, ICarrinho carrinho, ILivro livro);

		Task AddPedido(ICarrinhoLivro CarrinhoLivro, IPedido pedido);
	}
}
