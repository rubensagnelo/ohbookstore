using ohbookstore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public sealed class GerarPedidoEntrada
	{

		public Guid idPedido { get; set; }
		public Pessoa Cliente { get; set; }
		public Livros livros { get; set; }
		public DateTime DataHoraSolicitacao { get; set; }

		public GerarPedidoEntrada(Guid idPedido, Pessoa cliente, Livros livros, DateTime dataHoraSolicitacao)
		{
			this.idPedido = idPedido;
			Cliente = cliente;
			this.livros = livros;
			DataHoraSolicitacao = dataHoraSolicitacao;
		}


	}
}
