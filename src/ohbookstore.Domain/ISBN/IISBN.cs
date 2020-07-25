namespace ohbookstore.Domain
{
	public interface IISBN
	{
		string digito { get; }
		string editor { get; }
		string grupo { get; }
		string id { get; set; }
		string item { get; }
	}
}