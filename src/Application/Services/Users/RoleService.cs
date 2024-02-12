using Application.Abstractions.Users;
using Application.DataTransferObjects.Users;
using Application.Services.Contracts.Users;
using Application.ViewModel;
using Domain.Entities.Users;
using Mapster;

namespace Application.Services.Users
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
            => _roleRepository = roleRepository;

        public async ValueTask<RoleViewModel> AddAsync(RoleCreateionDTO roleCreateionDTO)
        {
            var role = roleCreateionDTO.Adapt<Role>();
            var result = _roleRepository.InsertAsync(role);
            var roleViewModel = result.Adapt<RoleViewModel>();

            return roleViewModel;
        }

        public async ValueTask<RoleViewModel> DeleteAsync(long id)
        {
            var result = await _roleRepository.DeleteAsync(id);
            var roleViewModel = result.Adapt<RoleViewModel>();

            return roleViewModel;
        }

        public async ValueTask<List<RoleViewModel>> GetAllAsync()
        {
            var result = _roleRepository.SelectAll();
            var roleViewModels = result.ToList().Adapt<List<RoleViewModel>>();

            return roleViewModels;
        }

        public async ValueTask<RoleViewModel> GetByIdAsync(long id)
        {
            var result = await _roleRepository.SelectByIdAsync(id);
            var roleViewModel = result.Adapt<RoleViewModel>();

            return roleViewModel;
        }

        public async ValueTask<RoleViewModel> UpdateAsync(RoleModificationDTO roleModificationDTO, long id)
        {
            var role = roleModificationDTO.Adapt<Role>();
            role.Id = id;
            var result = await _roleRepository.UpdateAsync(role);
            var roleViewModel = result.Adapt<RoleViewModel>();

            return roleViewModel;
        }
    }
}