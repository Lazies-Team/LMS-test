using Application.Abstractions.Users;
using Domain.Entities.Users;
using Domain.Exceptions.Users.User;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
            => _context = context;

        public async ValueTask<User> InsertAsync(User entity)
        {
            var entry = await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public IQueryable<User> SelectAll()
        {
            var users = _context.Users.AsNoTracking();

            return users;
        }

        public async ValueTask<User> SelectByIdAsync(long id)
        {
            var user = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (user is null)
                throw new UserNotFound();

            return user;
        }

        public async ValueTask<User> UpdateAsync(User entity)
        {
            var user = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (user is null)
                throw new UserNotFound();

            user = entity.Adapt(user);

            var entry = _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async ValueTask<User> DeleteAsync(long id)
        {
            var user = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (user is null)
                throw new UserNotFound();

            var entry = _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
