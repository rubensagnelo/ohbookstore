using ohbookstore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public sealed class IncluirLivroCarrinhoEntrada
	{
		public Carrinho Carrinho { get; set; }
		public Livro Livro { get; set; }

		public IncluirLivroCarrinhoEntrada(Carrinho carrinho, Livro livro)
		{
			this.Carrinho = carrinho;
			this.Livro = livro;
		}
	}
}
