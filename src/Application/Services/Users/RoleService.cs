using Application.Abstractions.Users;
using Application.DataTransferObjects.Users;
using Application.Services.Contracts.Users;
using Domain.Entities.Users;
using Mapster;

namespace Application.Services.Users
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
            => _roleRepository = roleRepository;

        public async ValueTask<Role> AddAsync(RoleCreateionDTO roleCreateionDTO)
        {
            var role = roleCreateionDTO.Adapt<Role>();
            var result = await _roleRepository.InsertAsync(role);

            return result;
        }

        public async ValueTask<Role> DeleteAsync(long id)
        {
            var result = await _roleRepository.DeleteAsync(id);
            var Role = result.Adapt<Role>();

            return Role;
        }

        public async ValueTask<List<Role>> GetAllAsync()
        {
            var result = _roleRepository.SelectAll().ToList();

            return result;
        }

        public async ValueTask<Role> GetByIdAsync(long id)
        {
            var result = await _roleRepository.SelectByIdAsync(id);

            return result;
        }

        public async ValueTask<Role> UpdateAsync(RoleModificationDTO roleModificationDTO, long id)
        {
            var role = roleModificationDTO.Adapt<Role>();
            role.Id = id;

            var result = await _roleRepository.UpdateAsync(role);

            return result;
        }
    }
}