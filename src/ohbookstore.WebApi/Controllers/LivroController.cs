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
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {


		public  async Task<IActionResult > Cadastrar(
		[FromServices] CadastrarLivroPresenter presenter,
		[FromForm] CadastrarLivroRequest request)
		{

			var input = new CadastrarLivroEntrada(new ISBN(request.isbn), request.nome, request.preco, request.autor);

			/* Mediator não funciona na minha versão de VSS2017 pq precisa de .net core acima de 2.1 */
			/*
			await mediator.PublishAsync(input)
				.ConfigureAwait(false); */

			return presenter.ViewModel;
		}


		// GET: api/Livro
		[HttpGet]
        public IEnumerable<string> Get()
        {
			
			
            return new string[] { "value1", "value2" };
        }

        // GET: api/Livro/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Livro
        [HttpPost]
        public void Post([FromBody] CadastrarLivroEntrada value)
        {


		}

        // PUT: api/Livro/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }




	}
}
