using System;

namespace ohbookstore.Domain
{
	public interface IPedido
	{
		Pessoa Cliente { get; set; }
		Livros livros { get; set; }
		DateTime DataHoraSolicitacao { get; set; }
	}
}