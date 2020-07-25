using ohbookstore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public sealed class GerarPedidoSaida
	{
		public Pedido Pedido { get; set; }

		public GerarPedidoSaida(Pedido pedido)
		{
			Pedido = pedido;
		}

	}
}
