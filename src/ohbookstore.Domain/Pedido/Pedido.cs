using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Domain
{
	public class Pedido : dominiobase, IPedido
	{
		public Guid idPedido { get; set; }
		public Pessoa Cliente { get; set; }
		public Livros livros { get; set; }
		public DateTime DataHoraSolicitacao { get; set; }


		public Pedido(Pessoa cliente, Livros livros, DateTime dataHoraSolicitacao)
		{
			this.idPedido = new Guid();
			Cliente = cliente;
			this.livros = livros;
			DataHoraSolicitacao = dataHoraSolicitacao;
		}

	}
}
