using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Application.Boundaries
{
	public interface ISaidaPadraoPort<in TUseCaseOutput>
	{
		void Standard(TUseCaseOutput output);
	}
}
