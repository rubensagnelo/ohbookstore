using System;

namespace ohbookstore.Domain
{
	public interface IPessoa
	{
		string email { get; set; }
		Endereco endereco { get; set; }
		Guid id { get; set; }
		string Nome { get; set; }
		string Telefone { get; set; }
	}
}