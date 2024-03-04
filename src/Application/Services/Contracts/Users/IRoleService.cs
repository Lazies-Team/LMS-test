using Application.DataTransferObjects.Users;
using Domain.Entities.Users;

namespace Application.Services.Contracts.Users
{
    public interface IRoleService
    {
        ValueTask<Role> AddAsync(RoleCreateionDTO roleCreateionDTO);
        ValueTask<List<Role>> GetAllAsync();
        ValueTask<Role> GetByIdAsync(long id);
        ValueTask<Role> UpdateAsync(RoleModificationDTO roleModificationDTO, long id);
        ValueTask<Role> DeleteAsync(long id);
    }
}
