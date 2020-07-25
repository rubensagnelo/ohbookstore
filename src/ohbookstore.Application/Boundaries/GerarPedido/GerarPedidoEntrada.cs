using ohbookstore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public sealed class GerarPedidoEntrada
	{
		public Pedido Pedido { get; set; }

		public GerarPedidoEntrada(Pedido pedido)
		{
			Pedido = pedido;
		}
	}
}
