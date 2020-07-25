using System;
using System.Collections.Generic;
using System.Text;
using ohbookstore.Domain;

namespace ohbookstore.Application.Boundaries
{
	public sealed class CadastrarLivroEntrada
	{

		public ISBN isbn { get; set; }
		public string nome { get; set; }
		public decimal preco { get; set; }
		public String autor { get; set; }

		public CadastrarLivroEntrada(ISBN isbn, string nome, decimal preco, string autor)
		{
			this.isbn = isbn;
			this.nome = nome;
			this.preco = preco;
			this.autor = autor;
		}

	}
}
