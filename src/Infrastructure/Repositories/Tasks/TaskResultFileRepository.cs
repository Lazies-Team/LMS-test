using Application.Abstractions.Tasks;
using Domain.Entities.Tasks;
using Domain.Exceptions.Task;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Tasks
{
    public class TaskResultFileRepository : ITaskResultFileRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskResultFileRepository(ApplicationDbContext context)
            => _context = context;

        public async ValueTask<TaskResultFile> DeleteAsync(long id)
        {
            var taskResultFile = await _context.TaskResultFiles
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (taskResultFile == null)
                throw new TaskResultFileNotFound();

            var entry = _context.TaskResultFiles.Remove(taskResultFile);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async ValueTask<TaskResultFile> InsertAsync(TaskResultFile entity)
        {
            var entry = await _context.TaskResultFiles.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public IQueryable<TaskResultFile> SelectAll()
        {
            IQueryable<TaskResultFile> taskResultFiles = _context.TaskResultFiles.AsNoTracking();

            return taskResultFiles;
        }

        public async ValueTask<TaskResultFile> SelectByIdAsync(long id)
        {
            var taskResultFile = await _context.TaskResultFiles
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (taskResultFile == null)
                throw new TaskResultFileNotFound();

            return taskResultFile;
        }

        public async ValueTask<TaskResultFile> UpdateAsync(TaskResultFile entity)
        {
            var taskResultFile = await _context.TaskResultFiles
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (taskResultFile == null)
                throw new TaskResultFileNotFound();

            taskResultFile = entity.Adapt(entity);
            var entry = _context.TaskResultFiles.Update(taskResultFile);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
