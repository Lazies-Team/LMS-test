using Domain.Entities.Users;

namespace Application.Abstractions.Users
{
    public interface ITeacherRepository : IGenericRepository<Teacher>
    {
        public IQueryable<Teacher> SelectAll(List<long> ids);
    }
}
