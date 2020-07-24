using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Domain
{
	public class erro
	{
		public string id { get; }
		public string descricao { get; }


		public erro(string dominio, Int32 Id, string Descricao) {
			id = $"{dominio}{Id.ToString()}";
			descricao = Descricao;
		}
	}
}
