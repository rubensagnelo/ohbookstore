using System;
using System.Collections.Generic;
using System.Text;


namespace ohbookstore.Domain
{
    public class dominiobase
	{
		private erro _erro;
		public erro erro { get { return _erro; } }


		public void SetErro(Int32 id, string mensagem){
			_erro = new erro(this.GetType().Name.ToString(), id, mensagem);
		}


	}
}
