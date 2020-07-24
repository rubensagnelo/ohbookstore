using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public interface IGerarPedidoSaidaPort : ISaidaPadraoPort<GerarPedidoSaida>, ISaidaNaoEncontradaPort, ISaidaErroPort
	{
    }
}
