using Application.Abstractions.Homeworks;
using Domain.Entities.Homeworks;
using Domain.Exceptions.HomeWork;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Homeworks
{
    public class HomeworkRepository : IHomeworkRepository
    {
        private readonly ApplicationDbContext _context;

        public HomeworkRepository(ApplicationDbContext context)
            => _context = context;

        public async ValueTask<Homework> DeleteAsync(long id)
        {
            Homework? homework = await _context.Homeworks
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (homework == null)
                throw new HomeWorkNotFound();

            var entry = _context.Homeworks.Remove(homework);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async ValueTask<Homework> InsertAsync(Homework entity)
        {
            var entry = await _context.Homeworks.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public IQueryable<Homework> SelectAll()
        {
            IQueryable<Homework> homeworks = _context.Homeworks.AsNoTracking();

            return homeworks;
        }

        public async ValueTask<Homework> SelectByIdAsync(long id)
        {
            var homework = await _context.Homeworks
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (homework == null)
                throw new HomeWorkNotFound();

            return homework;
        }

        public async ValueTask<Homework> UpdateAsync(Homework entity)
        {
            var homework = await _context.Homeworks
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (homework == null)
                throw new HomeWorkNotFound();

            homework = entity.Adapt(homework);
            var entry = _context.Homeworks.Update(homework);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
