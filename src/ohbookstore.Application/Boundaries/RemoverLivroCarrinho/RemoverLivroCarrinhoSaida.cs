using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public sealed class RemoverLivroCarrinhoSaida
	{
		public Guid idCarrinho { get; set; }
		public string isbn { get; set; }

		public RemoverLivroCarrinhoSaida(Guid IdCarrinho, string isbn)
		{
			this.idCarrinho = IdCarrinho;
			this.isbn = isbn;
		}

	}
}
