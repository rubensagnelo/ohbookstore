using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public sealed class EditarLivroSaida
	{
		public string ISBN { get; }

		public EditarLivroSaida(string iSBN)
		{
			ISBN = iSBN;
		}


	}
}
