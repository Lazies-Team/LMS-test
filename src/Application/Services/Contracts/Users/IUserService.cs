using Application.DataTransferObjects.Users;

using Domain.Entities.Users;
namespace Application.Services.Contracts.Users
{
    public interface IUserService
    {
        ValueTask<User> AddAsync(UserCreationDTO userCreationDTO);
        ValueTask<List<User>> GetAllAsync();
        ValueTask<User> GetByIdAsync(long id);
        ValueTask<User> UpdateAsync(UserModificationDTO userModificationDTO, long id);
        ValueTask<User> DeleteAsync(long id);
    }
}
