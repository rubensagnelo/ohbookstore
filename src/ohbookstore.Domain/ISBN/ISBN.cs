using System;
using System.Collections.Generic;
using System.Text;

namespace ohbookstore.Domain
{
	public class ISBN : dominiobase, IISBN
	{

		/// <summary>
		///  id: International Standard Book Number
		/// </summary>
		private string _id;
		public string id { get { return _id; } set { setid(value); } }

		public string EAN { get; private set; }
		public string grupo { get; private set; } 
		public string editor { get; private set; }
		public string item { get; private set; } 
		public string digito { get; private set; }



		public ISBN(string Id) {
			setid(Id);
		}

		const short tamanhoISBN = 13;

		private void setid(string value) {
			if (value.Length != tamanhoISBN)
				SetErro(1, $"O ISBN deve ter {tamanhoISBN} caracteres.");
			_id = value;
			setTodos();
		}

		private void setEAN() {
			EAN = _id.Substring(0, 3);
		}

		private void setgrupo() {
			grupo = _id.Substring(3, 2);
		}

		private void geteditor(){
			editor = _id.Substring(5, 4);
		}
		

		private void getitem()
		{
			item = _id.Substring(9, 3);
		}

		private void getdigito()
		{
			digito = _id.Substring(12, 1);
		}

		private void setTodos() {
			setEAN();
			setgrupo();
			geteditor();
			getitem();
			getdigito();
		}


	}
}
