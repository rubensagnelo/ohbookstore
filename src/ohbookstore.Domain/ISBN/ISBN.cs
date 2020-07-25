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
		public string id { get { return _id; } set { _id = value; } }

		public string grupo { get { return getgrupo(); } }
		public string editor { get { return geteditor(); } }
		public string item { get { return getitem(); } }
		public string digito { get { return getitem(); } }



		const short tamanhoISBN = 13;

		private void setid(string value) {
			if (value.Length != tamanhoISBN)
				SetErro(1, $"O ISBN deve ter {tamanhoISBN} caracteres.");
			_id = value;
		}


		private string getgrupo() {
			string result = string.Empty;

			return result;
		}

		private string geteditor(){
			string result = string.Empty;

			return result;
		}
		

		private string getitem()
		{
			string result = string.Empty;

			return result;
		}

		private string getdigito()
		{
			string result = string.Empty;

			return result;
		}


	}
}
