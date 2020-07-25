using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ohbookstore.Application.Boundaries;
using ohbookstore.Domain;

namespace ohbookstore.Application.UseCases
{
	public sealed class CadastrarLivroUseCase : Boundaries.ICadastrarLivroUseCase
	{

		private readonly ICadastroLivroRepository _CadastroLivroRepository;
		private readonly CadastroLivroService _CadastroLivroService;
		private readonly ICadastrarLivroSaidaPort _CadastrarLivroSaidaPort;
		private readonly IUnitOfWork _unitOfWork;

		public CadastrarLivroUseCase(
			ICadastroLivroRepository CadastroLivroRepository, 
			CadastroLivroService CadastroLivroService, 
			ICadastrarLivroSaidaPort CadastrarLivroSaidaPort, 
			IUnitOfWork unitOfWork)
		{
			_CadastroLivroRepository = CadastroLivroRepository;
			_CadastroLivroService = CadastroLivroService;
			_CadastrarLivroSaidaPort = CadastrarLivroSaidaPort;
			_unitOfWork = unitOfWork;
		}


		public async Task executar(Boundaries.CadastrarLivroEntrada entrada) {

			if (entrada is null)
			{
				this._CadastrarLivroSaidaPort.WriteError("entrada não pode ser nula");
				return;
			}

			ICadastroLivro CadastroLivro = await this._CadastroLivroRepository.GetCadastroLivro().ConfigureAwait(false);

			//CadastroLivro.IncluirLivro(

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
