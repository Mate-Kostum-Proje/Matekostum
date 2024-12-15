using Mate.BL.Abstract;
using Mate.DAL.GenericRepository.Concrete;
using Mate.Entities.Abstract;

namespace Mate.BL.Concrete
{
	public class Manager<T> : Repository<T>, IManager<T> where T : BaseEntity
	{
	}
}
