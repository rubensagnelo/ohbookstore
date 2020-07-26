using ohbookstore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public sealed class IncluirLivroCarrinhoSaida
	{
		public Livro Livro { get; set; }

		public IncluirLivroCarrinhoSaida(Livro livro)
		{
			this.Livro = livro;
		}

	}
}
