using System;

namespace ohbookstore.Domain
{
	public interface ICarrinho
	{
		Guid id { get; set; }
		Livros Livros { get; set; }
	}
}