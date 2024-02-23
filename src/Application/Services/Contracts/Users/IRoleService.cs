using Application.DataTransferObjects.Users;
using Application.ViewModel.Users;

namespace Application.Services.Contracts.Users
{
    public interface IRoleService
    {
        ValueTask<RoleViewModel> AddAsync(RoleCreateionDTO roleCreateionDTO);
        ValueTask<List<RoleViewModel>> GetAllAsync();
        ValueTask<RoleViewModel> GetByIdAsync(long id);
        ValueTask<RoleViewModel> UpdateAsync(RoleModificationDTO roleModificationDTO, long id);
        ValueTask<RoleViewModel> DeleteAsync(long id);
    }
}
