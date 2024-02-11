using Application.Abstractions.Tasks;
using Domain.Entities.Tasks;
using Domain.Exceptions.Task;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Tasks
{
    public class TaskResultRepository : ITaskResultRepository
    {
        private ApplicationDbContext _context;

        public TaskResultRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async ValueTask<TaskResult> DeleteAsync(long id)
        {
            var taskResult = await _context.TaskResults
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (taskResult == null)
                throw new TaskResultNotFound();

            var entry = _context.TaskResults.Remove(taskResult);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async ValueTask<TaskResult> InsertAsync(TaskResult entity)
        {
            var entry = await _context.TaskResults.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public IQueryable<TaskResult> SelectAll()
        {
            IQueryable<TaskResult> taskResults = _context.TaskResults.AsNoTracking();

            return taskResults;
        }

        public async ValueTask<TaskResult> SelectByIdAsync(long id)
        {
            var taskResult = await _context.TaskResults
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (taskResult == null)
                throw new TaskResultNotFound();

            return taskResult;
        }

        public async ValueTask<TaskResult> UpdateAsync(TaskResult entity)
        {
            var taskResult = await _context.TaskResults
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (taskResult == null)
                throw new TaskResultNotFound();

            taskResult = entity.Adapt(entity);
            var entry = _context.TaskResults.Update(taskResult);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}