namespace ohbookstore.Domain
{
	public interface ILivro
	{
		ISBN isbn { get; set; }
		string autor { get; set; }
		string nome { get; set; }
		decimal preco { get; set; }
	}
}