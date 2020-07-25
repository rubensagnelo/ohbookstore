﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;


namespace ohbookstore.WebApi.Controllers
{
	public class CadastrarLivroResponse 
	{
		[Required]
		public string iSBN { get; }

		public CadastrarLivroResponse(string iSBN)
		{
			this.iSBN = iSBN;
		}


	}
}
