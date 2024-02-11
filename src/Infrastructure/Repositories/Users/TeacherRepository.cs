using Application.Abstractions.Users;
using Domain.Entities.Users;
using Domain.Exceptions.Users.Teacher;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Users
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ApplicationDbContext _context;

        public TeacherRepository(ApplicationDbContext context)
            => _context = context;

        public async ValueTask<Teacher> InsertAsync(Teacher entity)
        {
            var entry = await _context.Teachers.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public IQueryable<Teacher> SelectAll()
        {
            var teachers = _context.Teachers.AsNoTracking();

            return teachers;
        }

        public async ValueTask<Teacher> SelectByIdAsync(long id)
        {
            var teacher = await _context.Teachers
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (teacher == null)
                throw new TeacherNotFound();

            return teacher;

        }

        public async ValueTask<Teacher> UpdateAsync(Teacher entity)
        {
            var teacher = await _context.Teachers
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == entity.Id);

            if(teacher == null)
                throw new TeacherNotFound();
                
            teacher = entity.Adapt(entity);
            var entry = _context.Teachers.Update(teacher);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async ValueTask<Teacher> DeleteAsync(long id)
        {
            var teacher = await _context.Teachers
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if(teacher == null)
                throw new TeacherNotFound();

            var entry = _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
