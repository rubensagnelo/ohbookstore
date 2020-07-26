using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ohbookstore.Domain
{
	public interface ICarrinhoLivro
	{

		ICarrinho IncluirCarrinho(ICarrinhoFactory entidadeFactory, Carrinho Carrinho);
		bool ExcluirCarrinho(ICarrinhoFactory entidadeFactory, Carrinho Carrinho);

		ILivro IncluirLivroCarrinho(ICarrinhoFactory entidadeFactory, Carrinho Carrinho, Livro Livro);
		bool ExcluirLivroCarrinho(ICarrinhoFactory entidadeFactory, Carrinho Carrinho, Livro Livro);

		IPedido EfetivarPedidoCarinho(ICarrinhoFactory entidadeFactory, Pedido Pedido);

	}
}
