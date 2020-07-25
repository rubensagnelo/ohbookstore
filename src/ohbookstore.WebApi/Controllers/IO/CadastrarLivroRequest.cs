using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ohbookstore.WebApi.Controllers
{
	public class CadastrarLivroRequest 
	{
		[Required]
		public string isbn { get ; set; }
		public string autor { get ;set ; }
		public string nome { get ; set; }
		public decimal preco { get ; set; }
	}
}
