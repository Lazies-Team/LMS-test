using Application.Abstractions.Courses;
using Domain.Entities.Courses;
using Domain.Exceptions.Course;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Courses
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext _context;

        public CourseRepository(ApplicationDbContext context)
            => _context = context;

        public async ValueTask<Course> DeleteAsync(long id)
        {
            Course? course = await _context.Course
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (course == null)
                throw new CourseNotFound();

            var entry = _context.Course.Remove(course);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async ValueTask<Course> InsertAsync(Course entity)
        {
            var entry = await _context.Course.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public IQueryable<Course> SelectAll()
        {
            var course = _context.Course.AsNoTracking();

            return course;
        }

        public async ValueTask<Course> SelectByIdAsync(long id)
        {
            Course? course = await _context.Course
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (course == null)
                throw new CourseNotFound();

            return course;
        }

        public async ValueTask<Course> UpdateAsync(Course entity)
        {
            Course? course = await _context.Course
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (course == null)
                throw new CourseNotFound();

            course = entity.Adapt(course);
            var entry = _context.Course.Update(course);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
