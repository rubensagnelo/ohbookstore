using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries.ExcluirLivro
{
	interface IExcluirLivroSaidaPort : ISaidaPadraoPort<ExcluirLivroSaida>, ISaidaNaoEncontradaPort, ISaidaErroPort
	{
	}
}
