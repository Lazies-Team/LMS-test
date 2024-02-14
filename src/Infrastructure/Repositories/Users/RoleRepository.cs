using Application.Abstractions.Users;
using Domain.Entities.Users;
using Domain.Exceptions.Users.Role;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Infrastructure.Repositories.Users
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
            => _context = context;

        public async ValueTask<Role> DeleteAsync(long id)
        {
            Role? role = await _context.Roles
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (role == null)
                throw new RoleNotFound();

            var entity = _context.Roles.Remove(role);
            await _context.SaveChangesAsync();

            return entity.Entity;
        }

        public async ValueTask<Role> InsertAsync(Role entity)
        {
            EntityEntry<Role>? entry = await _context.Roles.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public IQueryable<Role> SelectAll()
        {
            IQueryable<Role> roles = _context.Roles.AsNoTracking();

            return roles;
        }

        public async ValueTask<Role> SelectByIdAsync(long id)
        {
            Role? role = await _context.Roles
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (role == null)
                throw new RoleNotFound();

            return role;
        }

        public async ValueTask<Role> UpdateAsync(Role entity)
        {
            Role? role = await _context.Roles
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (role == null)
                throw new RoleNotFound();

            role = entity.Adapt(role);
            var entry = _context.Roles.Update(role);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
