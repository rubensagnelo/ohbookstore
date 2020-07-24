using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public interface IIncluirLivroCarrinhoSaidaPort : ISaidaPadraoPort<IncluirLivroCarrinhoSaida>, ISaidaNaoEncontradaPort, ISaidaErroPort
	{
	}
}
