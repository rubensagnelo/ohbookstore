﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Domain
{
	public class Carrinho : dominiobase, ICarrinho
	{
		public Livros Livros { get; set; }
	}
}
