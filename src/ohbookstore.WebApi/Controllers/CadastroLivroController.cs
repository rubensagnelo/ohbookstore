using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ohbookstore.Domain;
using ohbookstore.Application.Boundaries;


namespace ohbookstore.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CadastroLivroController : ControllerBase
    {

		#region CadastrarLivro

		// POST: api/Livro
		[HttpPost]
		public object CadastrarLivro([FromBody] CadastrarLivroRequest request)
		{

			var result = new CadastrarLivroEntrada(request.isbn, request.nome, request.preco, request.autor);

			/* mediator não funciona na minha versão de VSS2017 pq precisa de .net core acima de 2.1 */
			/*
			await mediator.PublishAsync(result)
				.ConfigureAwait(false); */



			return result;

		}

		[HttpPost]
		public async Task<IActionResult> Cadastrar(
		[FromServices] CadastrarLivroPresenter presenter,
		[FromForm] CadastrarLivroRequest request)
		{

			var inputmediator = new CadastrarLivroEntrada(request.isbn, request.nome, request.preco, request.autor);

			/* mediator não funciona na minha versão de VSS2017 pq precisa de .net core acima de 2.1 */
			/*
			await mediator.PublishAsync(inputmediator)
				.ConfigureAwait(false); */


			return presenter.ViewModel;

		}


		#endregion CadastrarLivro


		#region Excluir Livro

		// DELETE: api/ApiWithActions/5
		[HttpDelete]
		public Object Delete(string isbn)
		{
			var result = new ExcluirLivroEntrada(isbn);

			/* mediator não funciona na minha versão de VSS2017 pq precisa de .net core acima de 2.1 */
			/*
			await mediator.PublishAsync(result)
				.ConfigureAwait(false); */

			return result;
		}


		[HttpPost]
		public async Task<IActionResult> Delete(
				[FromServices] CadastrarLivroPresenter presenter,
				[FromForm] CadastrarLivroRequest request)
		{

			var inputmediator = new ExcluirLivroEntrada(request.isbn);

			/* mediator não funciona na minha versão de VSS2017 pq precisa de .net core acima de 2.1 */
			/*
			await mediator.PublishAsync(inputmediator)
				.ConfigureAwait(false); */

			return presenter.ViewModel;

		}


		#endregion Excluir Livro

		
		#region Alterar Livro

		// PUT: api/Livro/5
		[HttpPut("{id}")]
		public Object Put(int id, [FromBody] EditarLivroEntrada request)
		{
			var result = new EditarLivroEntrada(request.isbn.id, request.nome, request.preco, request.autor);

			/* mediator não funciona na minha versão de VSS2017 pq precisa de .net core acima de 2.1 */
			/*
			await mediator.PublishAsync(inputmediator)
				.ConfigureAwait(false); */

			return result;
		}

		#endregion Alterar Livro










		//// GET: api/Livro
		//[HttpGet]
		//      public IEnumerable<string> GetLivros()
		//      {
		//          return new string[] { "value1", "value2" };
		//      }

		//// GET: api/Livro/5
		//[HttpGet]
		//public string GetLivro(int id)
		//      {
		//          return "value";
		//      }

		//// DELETE: api/ApiWithActions/5
		//[HttpDelete("{id}")]
		//public void Delete(int id)
		//{
		//}

		public void gravar(string chave, object valor)
		{

			HttpContext.Session.SetString(chave, Newtonsoft.Json.JsonConvert.SerializeObject(valor));
		}

		public T recuperar<T>(string chave)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(HttpContext.Session.GetString(chave));
		}


	}
}
