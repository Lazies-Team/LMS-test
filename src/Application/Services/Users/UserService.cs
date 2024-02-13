using Application.Abstractions.Users;
using Application.DataTransferObjects.Users;
using Application.Halpers;
using Application.Services.Contracts.Users;
using Application.ViewModel;
using Domain.Entities.Users;
using Mapster;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Application.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IAdminRepository _adminRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public UserService(
            IUserRepository userRepository,
            IPasswordHasher passwordHasher,
            IConfiguration configuration,
            IWebHostEnvironment webHostEnvironment,
            IAdminRepository adminRepository,
            ITeacherRepository teacherRepository,
            IStudentRepository studentRepository)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _configuration = configuration;
            _webHostEnvironment = webHostEnvironment;
            _adminRepository = adminRepository;
            _teacherRepository = teacherRepository;
            _studentRepository = studentRepository;
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

            var result = await _userRepository.InsertAsync(user);

            if (userCreationDTO.RoleId == 1)
            {
                var student = new Student()
                {
                    UserId = result.Id,
                    User = result,
                    StudentKey = Guid.NewGuid().ToString(),
                };

                await _studentRepository.InsertAsync(student);
            }
            else if (userCreationDTO.RoleId == 2)
            {
                var teacher = new Teacher()
                {
                    UserId = result.Id,
                    User = result
                };

                await _teacherRepository.InsertAsync(teacher);
            }
            else if (userCreationDTO.RoleId == 3)
            {
                var admin = new Admin()
                {
                    UserId = result.Id,
                    User = result
                };
            }

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

            if (userModificationDTO.ProfilePhoto is not null)
            {
                string profilePhotoPath = await SavePhotoFile(userModificationDTO.ProfilePhoto);
                user.ProfilePhotoPath = profilePhotoPath;
            }

            var result = await _userRepository.UpdateAsync(user);
            var userViewModel = result.Adapt<UserViewModel>();

            return userViewModel;
        }

        private async Task<string> SavePhotoFile(IFormFile profilePhoto)
        {
            string uniqueFileName = string.Empty;
            if (profilePhoto != null)
            {
                string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "profile_photo");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + profilePhoto.FileName;
                string imageFilePath = Path.Combine(uploadFolder, uniqueFileName);
                profilePhoto.CopyTo(new FileStream(imageFilePath, FileMode.Create));
            }

            return uniqueFileName;
        }
    }
}
