using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Domain
{
	public class Pedido : dominiobase, IPedido
	{
		public Pessoa Cliente { get; set; }
		public Livros livros { get; set; }
		public DateTime DataHoraSolicitacao { get; set; }
	}
}
