using ohbookstore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public sealed class IncluirLivroCarrinhoEntrada
	{
		public Guid idCarrinho { get; set; }
		public Livro Livro { get; set; }

		public IncluirLivroCarrinhoEntrada(Guid IdCarrinho, Livro livro)
		{
			this.idCarrinho = IdCarrinho;
			Livro = livro;
		}
	}
}
