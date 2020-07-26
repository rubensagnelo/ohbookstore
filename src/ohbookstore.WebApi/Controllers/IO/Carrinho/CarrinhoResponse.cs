using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;


namespace ohbookstore.WebApi.Controllers
{
	public class CarrinhoResponse 
	{
		[Required]
		public string iSBN { get; }

		public CarrinhoResponse(string iSBN)
		{
			this.iSBN = iSBN;
		}


	}
}
