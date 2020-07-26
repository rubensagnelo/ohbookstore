using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ohbookstore.Domain;

namespace ohbookstore.WebApi.Controllers
{
	public class CarrinhoRequest 
	{
		[Required]
		public Carrinho Carrinho { get; set; }
		public Livro Livro { get; set; }
	}
}
