using ohbookstore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public sealed class IncluirLivroCarrinhoSaida
	{
		public Guid idCarrinho { get; set; }
		public string isbn { get; set; }

		public IncluirLivroCarrinhoSaida(Guid IdCarrinho, string isbn)
		{
			this.idCarrinho = IdCarrinho;
			this.isbn = isbn;
		}

	}
}
