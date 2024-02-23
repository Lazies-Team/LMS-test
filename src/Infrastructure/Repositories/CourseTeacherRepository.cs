using Application.Abstractions;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class CourseTeacherRepository : ICourseTeacherRepository
    {
        private readonly ApplicationDbContext _context;

        public CourseTeacherRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ValueTask<CourseTeacher> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<CourseTeacher> InsertAsync(CourseTeacher entity)
        {
            var entry = await _context.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public IQueryable<CourseTeacher> SelectAll()
        {
            throw new NotImplementedException();
        }

        public ValueTask<CourseTeacher> SelectByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<CourseTeacher> UpdateAsync(CourseTeacher entity)
        {
            throw new NotImplementedException();
        }
    }
}
