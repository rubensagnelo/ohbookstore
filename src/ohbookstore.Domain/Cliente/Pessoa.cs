using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Domain
{
	public class Pessoa : IPessoa
	{
		public Guid id { get; set; }
		public string Nome { get; set; }
		public Endereco endereco { get; set; }
		public string Telefone { get; set; }
		public string email { get; set; }
	}
}
