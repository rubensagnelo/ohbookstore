using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public sealed class ExcluirLivroSaida
	{
		public string ISBN { get; }

		public ExcluirLivroSaida(string iSBN)
		{
			ISBN = iSBN;
		}

	}
}
