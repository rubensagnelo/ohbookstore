using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Domain
{
	public class Livro : dominiobase, ILivro
	{

		public ISBN isbn { get; set; }
		public string nome { get; set; }
		public decimal preco { get; set; }
		public String autor { get; set; }


	}
}
