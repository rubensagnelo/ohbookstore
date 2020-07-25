using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public sealed class CadastrarLivroSaida
	{
		public string ISBN { get; }

		public CadastrarLivroSaida(string iSBN)
		{
			ISBN = iSBN;
		}

	}
}
