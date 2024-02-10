using Application.DataTransferObjects.Users;
using Application.ViewModel;

namespace Application.Services.Users
{
    public interface IUserService
    {
        ValueTask<UserViewModel> AddAsync(UserCreationDTO userCreationDTO);
        IQueryable<IList<UserViewModel>> GetAll();
        ValueTask<UserViewModel> GetByIdAsync(long id);
        ValueTask<UserViewModel> UpdateAsync(UserModificationDTO userModificationDTO);
        ValueTask<UserViewModel> DeleteAsync(long id);
    }
}
