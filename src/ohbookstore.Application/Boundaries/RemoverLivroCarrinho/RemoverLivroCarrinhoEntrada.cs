using ohbookstore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public sealed class RemoverLivroCarrinhoEntrada
	{
		public Carrinho Carrinho { get; set; }
		public Livro Livro { get; set; }

		public RemoverLivroCarrinhoEntrada(Carrinho carrinho, Livro livro)
		{
			this.Carrinho = carrinho;
			this.Livro = livro;
		}

	}
}
