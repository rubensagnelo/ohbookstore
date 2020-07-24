using System;
using System.Collections.Generic;
using System.Text;


namespace ohbookstore.Domain
{
    public class dominiobase
	{
		
		public erro erro { get; set; }


		public void SetErro(Int32 id, string mensagem){
			erro = new erro(this.GetType().Name.ToString(), id, mensagem);
		}


	}
}
