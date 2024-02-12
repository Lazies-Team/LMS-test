using Application.Abstractions.Tasks;
using Domain.Entities.Tasks;
using Domain.Exceptions.Task;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Tasks
{
    public class GradeRepository : IGradeRepository
    {
        private readonly ApplicationDbContext _context;

        public GradeRepository(ApplicationDbContext context)
            => _context = context;

        public async ValueTask<Grade> DeleteAsync(long id)
        {
            Grade? grade = await _context.Grades
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (grade == null)
                throw new GradeNotFound();

            var entry = _context.Grades.Remove(grade);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async ValueTask<Grade> InsertAsync(Grade entity)
        {
            var entry = await _context.Grades.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public IQueryable<Grade> SelectAll()
        {
            IQueryable<Grade> grades = _context.Grades.AsNoTracking();

            return grades;
        }

        public async ValueTask<Grade> SelectByIdAsync(long id)
        {
            var grade = await _context.Grades
                .AsNoTracking()
                .FirstOrDefaultAsync (x => x.Id == id);

            if (grade == null)
                throw new GradeNotFound();

            return grade;
        }

        public async ValueTask<Grade> UpdateAsync(Grade entity)
        {
            var grade = await _context.Grades
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (grade == null)
                throw new GradeNotFound();

            grade = entity.Adapt(grade);
            var entry = _context.Grades.Update(grade);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
