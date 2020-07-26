using ohbookstore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public sealed class RemoverLivroCarrinhoSaida
	{
		public Livro Livro { get; set; }

		public RemoverLivroCarrinhoSaida(Livro livro)
		{
			this.Livro = livro;
		}

	}
}
