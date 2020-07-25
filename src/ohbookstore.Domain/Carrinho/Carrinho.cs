using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Domain
{
	public class Carrinho : dominiobase, ICarrinho
	{
		public Guid id { get; set; }
		public Livros Livros { get; set; }
	}
}
