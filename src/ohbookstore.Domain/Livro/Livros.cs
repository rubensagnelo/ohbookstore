using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ohbookstore.Domain
{
    public class Livros : List<ILivro>, ILivros
	{

		public Decimal GetPrecoTotal()
		{
			return this.Sum(x => x.preco);
		}


	}
}
