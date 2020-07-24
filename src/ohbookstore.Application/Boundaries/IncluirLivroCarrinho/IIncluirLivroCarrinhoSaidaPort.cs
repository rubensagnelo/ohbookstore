using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries.IncluirLivroCarrinho
{
	interface IIncluirLivroCarrinhoSaidaPort : ISaidaPadraoPort<IncluirLivroCarrinhoSaida>, ISaidaNaoEncontradaPort, ISaidaErroPort
	{
	}
}
