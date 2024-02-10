using Application.Abstractions.Users;
using Application.DataTransferObjects.Users;
using Application.ViewModel;

namespace Application.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
            => _userRepository = userRepository;

        public ValueTask<UserViewModel> AddAsync(UserCreationDTO userCreationDTO)
        {
            throw new NotImplementedException();
        }

        public ValueTask<UserViewModel> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<IList<UserViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public ValueTask<UserViewModel> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<UserViewModel> UpdateAsync(UserModificationDTO userModificationDTO, long id)
        {
            throw new NotImplementedException();
        }
    }
}
