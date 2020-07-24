namespace ohbookstore.Domain
{
	public interface ILivro
	{
		string autor { get; set; }
		ISBN isbn { get; set; }
		string nome { get; set; }
		decimal preco { get; set; }
	}
}