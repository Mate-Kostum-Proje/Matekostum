using Mate.DAL.GenericRepository.Abstract;
using Mate.Entities.Abstract;

namespace Mate.BL.Abstract
{
	public interface IManager<T> : IRepository<T> where T : BaseEntity
	{

	}
}