using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ohbookstore.Application.Boundaries;

namespace ohbookstore.Application.UseCases
{
	public sealed class CadastrarLivroUseCase : Boundaries.ICadastrarLivroUseCase
	{

		ohbookstore.Domain.ICadastroLivroRepository _CadastroLivroRepository;


		//public CadastrarLivroUseCase(
		//	ICadastrarLivroSaidaPort cadastrarLivroSaidaPort,
		//	ohbookstore.Domain.

		//	)
		//{
		//}

		public async Task executar(Boundaries.CadastrarLivroEntrada entrada) {

			//if (entrada is null)
			//{
			//	this. _closeAccountOutputPort
			//		.WriteError(Messages.InputIsNull);
			//	return;
			//}

			Boundaries.CadastrarLivroSaida result = new Boundaries.CadastrarLivroSaida();

			
			//var output = new Boundaries.CadastrarLivroSaida(id);
		}

		public Task Executar(CadastrarLivroEntrada entrada)
		{

			throw new NotImplementedException();
		}
	}
}
