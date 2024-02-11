using Application.Abstractions.Homeworks;
using Domain.Entities.Homeworks;
using Domain.Exceptions.HomeWork;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Homeworks
{
    public class HomeworkFileRepository : IHomeworkFileRepository
    {
        private readonly ApplicationDbContext _context;

        public HomeworkFileRepository(ApplicationDbContext context)
            => _context = context;

        public async ValueTask<HomeworkFile> DeleteAsync(long id)
        {
            HomeworkFile? homeworkFile = await _context.HomeworkFiles
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (homeworkFile == null)
                throw new HomeworkFileNotFound();

            var entry = _context.HomeworkFiles.Remove(homeworkFile);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async ValueTask<HomeworkFile> InsertAsync(HomeworkFile entity)
        {
            var entry = await _context.HomeworkFiles.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public IQueryable<HomeworkFile> SelectAll()
        {
            IQueryable<HomeworkFile> homeworkFiles = _context.HomeworkFiles.AsNoTracking();

            return homeworkFiles;
        }

        public async ValueTask<HomeworkFile> SelectByIdAsync(long id)
        {
            HomeworkFile? homeworkFile = await _context.HomeworkFiles
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (homeworkFile == null)
                throw new HomeworkFileNotFound();

            return homeworkFile;
        }

        public async ValueTask<HomeworkFile> UpdateAsync(HomeworkFile entity)
        {
            HomeworkFile? homeworkFile = await _context.HomeworkFiles
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (homeworkFile == null)
                throw new HomeworkFileNotFound();

            homeworkFile = entity.Adapt(homeworkFile);
            var entry = _context.HomeworkFiles.Update(homeworkFile);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
