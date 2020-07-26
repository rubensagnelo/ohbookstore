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
			await this._CarrinhoRepository.Add(CarrinhoLivro, carrinho).ConfigureAwait(false);

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

			if (result)
				await this._CarrinhoRepository.Delete(CarrinhoLivro, carrinho).ConfigureAwait(false);
			else
				carrinho = null;

			return carrinho;
		}

		public async Task<ILivro> IncluirLivroNoCarrinho(ICarrinhoLivro CarrinhoLivro, Carrinho Carrinho, Livro Livro)
		{
			if (CarrinhoLivro is null)
			{
				throw new ArgumentNullException(nameof(CarrinhoLivro));
			}


			if (Carrinho is null)
			{
				throw new ArgumentNullException(nameof(Carrinho));
			}


			if (Livro is null)
			{
				throw new ArgumentNullException(nameof(Livro));
			}


			ILivro livro = CarrinhoLivro.IncluirLivroCarrinho(this._CarrinhoFactory, Carrinho, Livro);
			ICarrinho carrinho = (ICarrinho)Carrinho;
			await this._CarrinhoRepository.AddLivro(CarrinhoLivro, carrinho, livro).ConfigureAwait(false);

			return livro;
		}

		public async Task<ILivro> RemoverLivroDoCarrinho(ICarrinhoLivro CarrinhoLivro, Carrinho Carrinho, Livro Livro)
		{
			if (CarrinhoLivro is null)
			{
				throw new ArgumentNullException(nameof(CarrinhoLivro));
			}


			if (Carrinho is null)
			{
				throw new ArgumentNullException(nameof(Carrinho));
			}


			if (Livro is null)
			{
				throw new ArgumentNullException(nameof(Livro));
			}


			bool result = CarrinhoLivro.ExcluirLivroCarrinho(this._CarrinhoFactory, Carrinho, Livro);

			ICarrinho carrinho = (ICarrinho)Carrinho;
			ILivro livro = (ILivro)Livro;

			if (result)
				await this._CarrinhoRepository.DeleteLivro(CarrinhoLivro, carrinho, livro).ConfigureAwait(false);
			else
				livro = null;

			return livro;
		}


		public async Task<IPedido> GerarPedido(ICarrinhoLivro CarrinhoLivro, Livros Livros, Pessoa Cliente)
		{
			if (CarrinhoLivro is null)
			{
				throw new ArgumentNullException(nameof(CarrinhoLivro));
			}


			if (Livros is null || Livros.Count<= 0)
			{
				throw new ArgumentNullException(nameof(Livros));
			}


			if (Cliente is null)
			{
				throw new ArgumentNullException(nameof(Cliente));
			}

			Pedido fPedido = new Pedido(Cliente, Livros, DateTime.Now); 

			IPedido pedido = CarrinhoLivro.EfetivarPedidoCarinho(this._CarrinhoFactory, fPedido);
			await this._CarrinhoRepository.AddPedido(CarrinhoLivro, pedido).ConfigureAwait(false);

			return pedido;
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
