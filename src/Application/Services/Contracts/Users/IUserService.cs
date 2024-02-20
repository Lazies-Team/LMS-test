using Application.DataTransferObjects.Users;
using Application.ViewModel.Users;

namespace Application.Services.Contracts.Users
{
    public interface IUserService
    {
        ValueTask<UserViewModel> AddAsync(UserCreationDTO userCreationDTO);
        ValueTask<List<UserViewModel>> GetAllAsync();
        ValueTask<UserViewModel> GetByIdAsync(long id);
        ValueTask<UserViewModel> UpdateAsync(UserModificationDTO userModificationDTO, long id);
        ValueTask<UserViewModel> DeleteAsync(long id);
    }
}
