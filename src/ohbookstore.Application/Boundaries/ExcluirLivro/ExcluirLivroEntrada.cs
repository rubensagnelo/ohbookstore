using System;
using System.Collections.Generic;
using System.Text;
using ohbookstore.Domain;

namespace ohbookstore.Application.Boundaries
{
	public sealed class ExcluirLivroEntrada
	{
		public ISBN isbn { get; set; }

		public ExcluirLivroEntrada(string isbn)
		{
			this.isbn = new ISBN(isbn);
		}

	}
}
