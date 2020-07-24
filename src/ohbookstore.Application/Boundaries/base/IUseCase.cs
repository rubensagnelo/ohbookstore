using System.Threading.Tasks;

namespace ohbookstore.Application.Boundaries
{
	public interface IUseCase<in TUseCaseInput>
	{
		Task Executar(TUseCaseInput entrada);
	}
}
