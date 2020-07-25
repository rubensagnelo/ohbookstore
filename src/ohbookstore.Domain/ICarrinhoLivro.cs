using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Domain
{
	public interface ICarrinhoLivro
	{

		ICarrinho IncluirCarrinho(ICarrinhoFactory entidadeFactory, Carrinho Carrinho);
		bool ExcluirCarrinho(ICarrinhoFactory entidadeFactory, Carrinho Carrinho);

		ICarrinho IncluirLivroCarrinho(ICarrinhoFactory entidadeFactory, Carrinho Carrinho, Livro Livro);
		bool ExcluirLivroCarrinho(ICadastroLivroFactory entidadeFactory, Carrinho Carrinho, Livro Livro);

		Pedido EfetivarPedidoCarinho(ICadastroLivroFactory entidadeFactory, Livros Livros, Carrinho Carrinho);

	}
}
