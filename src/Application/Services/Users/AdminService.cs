using Application.Abstractions.Users;
using Application.DataTransferObjects.Users;
using Application.Services.Contracts.Users;
using Application.ViewModel.Users;
using Domain.Entities.Users;
using Mapster;

namespace Application.Services.Users
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
            => _adminRepository = adminRepository;

        public async ValueTask<AdminViewModel> DeleteAsync(long id)
        {
            var result = await _adminRepository.DeleteAsync(id);
            var adminViewModel = result.Adapt<AdminViewModel>();

            return adminViewModel;
        }

        public async ValueTask<List<AdminViewModel>> GetAllAsync()
        {
            var result = _adminRepository.SelectAll();
            var adminViewModels = result.ToList().Adapt<List<AdminViewModel>>();

            return adminViewModels;
        }

        public async ValueTask<AdminViewModel> GetByIdAsync(long id)
        {
            var result = await _adminRepository.SelectByIdAsync(id);
            var adminViewModel = result.Adapt<AdminViewModel>();

            return adminViewModel;
        }

        public async ValueTask<AdminViewModel> UpdateAsync(AdminModificationDTO adminModificationDTO, long id)
        {
            var admin = adminModificationDTO.Adapt<Admin>();
            admin.Id = id;

            var result = await _adminRepository.UpdateAsync(admin);
            var adminViewModel = result.Adapt<AdminViewModel>();

            return adminViewModel;
        }
    }
}
