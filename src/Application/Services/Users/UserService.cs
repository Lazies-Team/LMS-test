using Application.Abstractions.Users;
using Application.DataTransferObjects.Users;
using Application.Halpers.Hasher;
using Application.Services.Contracts.Users;
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

        public async ValueTask<User> AddAsync(UserCreationDTO userCreationDTO)
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
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                };

                await _studentRepository.InsertAsync(student);
            }
            else if (userCreationDTO.RoleId == 2)
            {
                var teacher = new Teacher()
                {
                    UserId = result.Id,
                    User = result,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                };

                await _teacherRepository.InsertAsync(teacher);
            }
            else if (userCreationDTO.RoleId == 3)
            {
                var admin = new Admin()
                {
                    UserId = result.Id,
                    User = result,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                };

                await _adminRepository.InsertAsync(admin);
            }

            User User = result.Adapt<User>();

            return User;
        }

        public async ValueTask<User> DeleteAsync(long id)
        {
            var result = await _userRepository.DeleteAsync(id);

            return result;
        }

        public async ValueTask<List<User>> GetAllAsync()
        {
            var result = _userRepository.SelectAll().ToList();

            return result;
        }

        public async ValueTask<User> GetByIdAsync(long id)
        {
            var result = await _userRepository.SelectByIdAsync(id);

            return result;
        }

        public async ValueTask<User> UpdateAsync(UserModificationDTO userModificationDTO, long id)
        {
            var user = userModificationDTO.Adapt<User>();
            user.Id = id;

            if (userModificationDTO.ProfilePhoto is not null)
            {
                string profilePhotoPath = await SavePhotoFile(userModificationDTO.ProfilePhoto);
                user.ProfilePhotoPath = profilePhotoPath;
            }

            var result = await _userRepository.UpdateAsync(user);

            return result;
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
