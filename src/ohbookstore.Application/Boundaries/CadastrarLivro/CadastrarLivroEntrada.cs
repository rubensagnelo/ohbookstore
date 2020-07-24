using System;
using System.Collections.Generic;
using System.Text;
using ohbookstore.Domain;

namespace ohbookstore.Application.Boundaries
{
	public sealed class CadastrarLivroEntrada
	{
		public CadastrarLivroEntrada(Livro livro)
		{
			Livro = livro;
		}

		public Domain.Livro Livro { get; }

	}
}
