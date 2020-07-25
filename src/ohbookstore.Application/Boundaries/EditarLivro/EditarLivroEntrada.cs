using System;
using System.Collections.Generic;
using System.Text;
using ohbookstore.Domain;

namespace ohbookstore.Application.Boundaries
{
	public sealed class EditarLivroEntrada
	{
		public ISBN isbn { get; set; }
		public string nome { get; set; }
		public decimal preco { get; set; }
		public String autor { get; set; }

		public EditarLivroEntrada(string isbn, string nome, decimal preco, string autor)
		{
			this.isbn = new ISBN(isbn);
			this.nome = nome;
			this.preco = preco;
			this.autor = autor;
		}

	}
}
