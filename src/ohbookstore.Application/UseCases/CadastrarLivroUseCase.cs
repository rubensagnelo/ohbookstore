using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ohbookstore.Application.Boundaries;

namespace ohbookstore.Application.UseCases
{
	public sealed class CadastrarLivroUseCase : Boundaries.ICadastrarLivroUseCase
	{
		public CadastrarLivroUseCase()
		{
		}

		public async Task executar(Boundaries.CadastrarLivroEntrada entrada) {
					   
			Boundaries.CadastrarLivroSaida result = new Boundaries.CadastrarLivroSaida();

			
			//var output = new Boundaries.CadastrarLivroSaida(id);
		}

		public Task Executar(CadastrarLivroEntrada entrada)
		{

			throw new NotImplementedException();
		}
	}
}
