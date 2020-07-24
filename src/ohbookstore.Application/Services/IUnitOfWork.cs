using System.Threading.Tasks;

namespace ohbookstore.Application
{
	public interface IUnitOfWork
	{
		Task<int> Save();
	}
}
