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
    public class CarrinhoController : ControllerBase
    {

		#region Incluir Livro no Carrinho

		[HttpPost]
		public object IncluirNoCarrinho([FromBody] IncluirLivroCarrinhoEntrada request)
		{
			var result = new IncluirLivroCarrinhoEntrada(request.Carrinho, request.Livro);

			HttpContext.Request.Headers["teste"] = "100";

			//DefaultHttpContext["aaaa"] = 10;

			/* mediator não funciona na minha versão de VSS2017 pq precisa de .net core acima de 2.1 */
			/*
			await mediator.PublishAsync(result)
				.ConfigureAwait(false); */

			return result;

		}


		#endregion Incluir Livro no Carrinho


		#region Remover Livro do carrinho

		// DELETE: api/ApiWithActions/5
		[HttpDelete]
		public Object RemoverDoCarrinho(RemoverLivroCarrinhoEntrada request)
		{
			var result = new RemoverLivroCarrinhoEntrada(request.Carrinho, request.Livro);

			/* mediator não funciona na minha versão de VSS2017 pq precisa de .net core acima de 2.1 */
			/*
			await mediator.PublishAsync(result)
				.ConfigureAwait(false); */

			return result;
		}

		#endregion Remover Livro do carrinho





		[HttpPost]
		public object GerarPedido([FromBody] GerarPedidoEntrada request)
		{
			var result = new GerarPedidoEntrada(request.idPedido, request.Cliente, request.livros, DateTime.Now);

			/* mediator não funciona na minha versão de VSS2017 pq precisa de .net core acima de 2.1 */
			/*
			await mediator.PublishAsync(result)
				.ConfigureAwait(false); */

			return result;

		}




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





		public void gravar(string chave, object valor)
		{

			HttpContext.Session.SetString(chave, Newtonsoft.Json.JsonConvert.SerializeObject(valor));
		}

		public T recuperar<T>(string chave)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(HttpContext.Session.GetString(chave));
		}




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




	}
}
