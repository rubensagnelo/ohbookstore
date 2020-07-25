﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ohbookstore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
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
        public void Post([FromBody] string value)
        {
			//Application.UseCases.CadastrarLivroUseCase

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


		//public async Task<IActionResult> Deposit(
		//[FromServices] IMediator mediator, [FromServices] DepositPresenter presenter,
		//[FromForm][Required] DepositRequest request)
		//{
		//	var input = new DepositInput(
		//		request.AccountId,
		//		request.Amount,
		//		request.Currency);

		//	await mediator.PublishAsync(input)
		//		.ConfigureAwait(false);

		//	return presenter.ViewModel!;
		//}

	}
}