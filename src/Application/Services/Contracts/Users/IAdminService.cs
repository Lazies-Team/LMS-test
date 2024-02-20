using Application.DataTransferObjects.Users;
using Application.ViewModel.Users;

namespace Application.Services.Contracts.Users
{
    public interface IAdminService
    {
        ValueTask<List<AdminViewModel>> GetAllAsync();
        ValueTask<AdminViewModel> GetByIdAsync(long id);
        ValueTask<AdminViewModel> UpdateAsync(AdminModificationDTO adminModificationDTO, long id);
        ValueTask<AdminViewModel> DeleteAsync(long id);
    }
}
