using Application.Abstractions.Users;
using Application.DataTransferObjects.Users;
using Application.Halpers;
using Application.ViewModel;
using Domain.Entities.Users;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Application.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IConfiguration _configuration;

        public UserService(
            IUserRepository userRepository,
            IPasswordHasher passwordHasher,
            IConfiguration configuration)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _configuration = configuration;
        }

        public async ValueTask<UserViewModel> AddAsync(UserCreationDTO userCreationDTO)
        {
            User user = userCreationDTO.Adapt<User>();
            var salt = Guid.NewGuid().ToString();
            var refreshToken = Guid.NewGuid().ToString();
            var passwordHash = _passwordHasher.Encrypt(userCreationDTO.Password, salt);
            var expireDate = DateTime.Now.AddDays(Convert.ToDouble(_configuration["RefreshTokenExpireDay"]));

            user.Salt = salt;
            user.RefreshToken = refreshToken;
            user.RefreshTokenExpireDate = expireDate;
            user.PasswordHash = passwordHash;

            if (userCreationDTO.ProfilePhoto is not null)
            {
                string profilePhotoPath = await SavePhotoFile(userCreationDTO.ProfilePhoto);
                user.ProfilePhotoPath = profilePhotoPath;
            }

            var result = await _userRepository.InsertAsync(user);
            UserViewModel userViewModel = result.Adapt<UserViewModel>();

            return userViewModel;
        }

        public async ValueTask<UserViewModel> DeleteAsync(long id)
        {
            var result = await _userRepository.DeleteAsync(id);
            UserViewModel userViewModel = result.Adapt<UserViewModel>();

            return userViewModel;
        }

        public async ValueTask<List<UserViewModel>> GetAllAsync()
        {
            var result = _userRepository.SelectAll();
            var userViewModels = result.ToList().Adapt<List<UserViewModel>>();

            return userViewModels;
        }

        public async ValueTask<UserViewModel> GetByIdAsync(long id)
        {
            var result = await _userRepository.SelectByIdAsync(id);
            var userViewModel = result.Adapt<UserViewModel>();

            return userViewModel;
        }

        public async ValueTask<UserViewModel> UpdateAsync(UserModificationDTO userModificationDTO, long id)
        {
            var user = userModificationDTO.Adapt<User>();
            user.Id = id;
            var result = await _userRepository.UpdateAsync(user);
            var userViewModel = result.Adapt<UserViewModel>();

            return userViewModel;
        }

        private async Task<string> SavePhotoFile(IFormFile profilePhoto)
            => throw new NotImplementedException();
    }
}
