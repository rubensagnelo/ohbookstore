using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public interface IEditarLivroSaidaPort : ISaidaPadraoPort<EditarLivroSaida>, ISaidaNaoEncontradaPort, ISaidaErroPort
	{
	}
}
