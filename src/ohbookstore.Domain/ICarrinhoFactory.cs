using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Domain
{
	public interface ICarrinhoFactory
	{
		ICadastroLivro NovoCarrinho(Guid idCarrinho);
		bool RemoverCarrinho(Guid idCarrinho);

		bool IncluirLivro(ICarrinho carrinho, ILivro livro);
		bool RemoverLivro(ICarrinho carrinho, ILivro livro);

		bool EfetivarComoPedido(ICarrinho carrinho, IPedido pedido);

	}
}
