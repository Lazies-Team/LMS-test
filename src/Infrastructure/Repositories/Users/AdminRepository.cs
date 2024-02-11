using Application.Abstractions.Users;
using Domain.Entities.Users;
using Domain.Exceptions.Users.Admin;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Users
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ApplicationDbContext _context;

        public AdminRepository(ApplicationDbContext context)
            => _context = context;

        public async ValueTask<Admin> DeleteAsync(long id)
        {
            Admin? admin = await _context.Admins
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (admin == null)
                throw new AdminNotFound();

            var enrty = _context.Admins.Remove(admin);
            await _context.SaveChangesAsync();

            return enrty.Entity;
        }

        public async ValueTask<Admin> InsertAsync(Admin entity)
        {
            var entry = await _context.Admins.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public IQueryable<Admin> SelectAll()
        {
            IQueryable<Admin>? admins = _context.Admins.AsNoTracking();

            return admins;
        }

        public async ValueTask<Admin> SelectByIdAsync(long id)
        {
            var admin = await _context.Admins
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (admin == null)
                throw new AdminNotFound();

            return admin;
        }

        public async ValueTask<Admin> UpdateAsync(Admin entity)
        {
            var admin = await _context.Admins
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (admin == null)
                throw new AdminNotFound();

            admin = entity.Adapt(entity);
            var entry = _context.Admins.Update(admin);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
