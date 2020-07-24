using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public interface IRemoverLivroCarrinhoSaidaPort : ISaidaPadraoPort<RemoverLivroCarrinhoSaida>, ISaidaNaoEncontradaPort, ISaidaErroPort
	{
	}
}
