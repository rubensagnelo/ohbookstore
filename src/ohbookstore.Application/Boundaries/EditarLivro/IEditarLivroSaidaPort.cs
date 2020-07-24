using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries.EditarLivro
{
	interface IEditarLivroSaidaPort : ISaidaPadraoPort<EditarLivroSaida>, ISaidaNaoEncontradaPort, ISaidaErroPort
	{
	}
}
