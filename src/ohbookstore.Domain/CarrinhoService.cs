using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ohbookstore.Domain
{
	public sealed class CarrinhoService
	{
		private readonly ICarrinhoFactory _CarrinhoFactory;
		private readonly ICarrinhoRepository _CarrinhoRepository;

		public CarrinhoService(ICarrinhoFactory CarrinhoFactory, ICarrinhoRepository CarrinhoRepository)
		{
			_CarrinhoFactory = CarrinhoFactory;
			_CarrinhoRepository = CarrinhoRepository;
		}


		public async Task<ICarrinho> CriarCarrinho(ICarrinhoLivro CarrinhoLivro, Carrinho Carrinho)
		{
			if (CarrinhoLivro is null)
			{
				throw new ArgumentNullException(nameof(CarrinhoLivro));
			}

			ICarrinho carrinho = CarrinhoLivro.IncluirCarrinho(this._CarrinhoFactory, Carrinho);
			await this._CarrinhoRepository.Add(carrinho).ConfigureAwait(false);

			return carrinho;
		}

		public async Task<ICarrinho> ExcluirCarrinho(ICarrinhoLivro CarrinhoLivro, Carrinho Carrinho)
		{
			if (CarrinhoLivro is null)
			{
				throw new ArgumentNullException(nameof(CarrinhoLivro));
			}

			if (Carrinho is null)
			{
				throw new ArgumentNullException(nameof(Carrinho));
			}

			bool result = false;

			result = CarrinhoLivro.ExcluirCarrinho(this._CarrinhoFactory, Carrinho);
			ICarrinho carrinho = (ICarrinho)Carrinho;
			await this._CarrinhoRepository.Delete(carrinho)
				.ConfigureAwait(false);

			return carrinho;
		}





		//public async Task<ILivro> CadastrarLivro(ICadastroLivro CadastroLivro, Livro Livro)
		//{
		//	if (CadastroLivro is null)
		//	{
		//		throw new ArgumentNullException(nameof(CadastroLivro));
		//	}

		//	if (Livro is null)
		//	{
		//		throw new ArgumentNullException(nameof(Livro));
		//	}

		//	ILivro livro = CadastroLivro.IncluirLivro(this._CadastroLivroFactory, Livro);
		//	await this._CadastroLivroRepository.Add(CadastroLivro, livro)
		//		.ConfigureAwait(false);

		//	return livro;
		//}

		//public async Task<ILivro> ExcluirLivro(ICadastroLivro CadastroLivro, Livro Livro)
		//{
		//	if (CadastroLivro is null)
		//	{
		//		throw new ArgumentNullException(nameof(CadastroLivro));
		//	}

		//	if (Livro is null)
		//	{
		//		throw new ArgumentNullException(nameof(Livro));
		//	}


		//	bool result = false;

		//	result = CadastroLivro.ExcluirLivro(this._CadastroLivroFactory, Livro);
		//	ILivro livro = (ILivro)Livro;
		//	await this._CadastroLivroRepository.Delete(CadastroLivro, livro)
		//		.ConfigureAwait(false);

		//	return livro;
		//}



		//public async Task<ILivro> AlterarLivro(ICadastroLivro CadastroLivro, Livro Livro)
		//{
		//	if (CadastroLivro is null)
		//	{
		//		throw new ArgumentNullException(nameof(CadastroLivro));
		//	}

		//	if (Livro is null)
		//	{
		//		throw new ArgumentNullException(nameof(Livro));
		//	}

		//	ILivro livro = CadastroLivro.ALterarLivro(this._CadastroLivroFactory, Livro);
		//	if (livro != null)
		//		await this._CadastroLivroRepository.Update(CadastroLivro, livro).ConfigureAwait(false);

		//	return livro;
		//}



	}
}
