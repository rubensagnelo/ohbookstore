using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries.GerarPedido
{
    interface IGerarPedidoSaidaPort : ISaidaPadraoPort<GerarPedidoSaida>, ISaidaNaoEncontradaPort, ISaidaErroPort
	{
    }
}
