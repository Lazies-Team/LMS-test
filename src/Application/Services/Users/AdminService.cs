using Application.Abstractions.Users;
using Application.DataTransferObjects.Users;
using Application.Services.Contracts.Users;
using Domain.Entities.Users;
using Mapster;

namespace Application.Services.Users
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
            => _adminRepository = adminRepository;

        public async ValueTask<Admin> DeleteAsync(long id)
        {
            var result = await _adminRepository.DeleteAsync(id);

            return result;
        }

        public async ValueTask<List<Admin>> GetAllAsync()
        {
            var result = _adminRepository.SelectAll().ToList();

            return result;
        }

        public async ValueTask<Admin> GetByIdAsync(long id)
        {
            var result = await _adminRepository.SelectByIdAsync(id);

            return result;
        }

        public async ValueTask<Admin> UpdateAsync(AdminModificationDTO adminModificationDTO, long id)
        {
            var admin = adminModificationDTO.Adapt<Admin>();
            admin.Id = id;

            var result = await _adminRepository.UpdateAsync(admin);

            return result;
        }
    }
}
