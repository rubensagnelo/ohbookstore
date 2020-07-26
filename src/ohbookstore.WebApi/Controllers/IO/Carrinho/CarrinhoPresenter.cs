using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ohbookstore.Application.Boundaries;
using Microsoft.AspNetCore.Mvc;

namespace ohbookstore.WebApi.Controllers
{
	public class CarrinhoPresenter : ICadastrarLivroSaidaPort
	{
		public IActionResult ViewModel { get; private set; }

		public void NotFound(string mensagem)
		{
			throw new NotImplementedException();
		}

		public void Standard(CadastrarLivroSaida output)
		{
			var CadastrarLivroResponse = new CarrinhoResponse(output.ISBN);
			this.ViewModel = new  ObjectResult(CadastrarLivroResponse);
		}

		public void WriteError(string mensagem)
		{
			throw new NotImplementedException();
		}
	}
}
