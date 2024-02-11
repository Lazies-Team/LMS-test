using Application.Abstractions.Users;
using Domain.Entities.Users;
using Domain.Exceptions.Users.Student;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Users
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
            => _context = context;        

        public async ValueTask<Student> InsertAsync(Student entity)
        {
            var entry = await _context.Students.AddAsync(entity);

            return entry.Entity;
        }

        public IQueryable<Student> SelectAll()
        {
            var students = _context.Students.AsNoTracking();

            return students;
        }

        public async ValueTask<Student> SelectByIdAsync(long id)
        {
            var student = await _context.Students
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (student == null)
                throw new StudentNotFound();

            return student;
        }

        public async ValueTask<Student> UpdateAsync(Student entity)
        {
            var student = await _context.Students
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (student == null)
                throw new StudentNotFound();

            student = entity.Adapt(student);
            var entry = _context.Students.Update(student);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async ValueTask<Student> DeleteAsync(long id)
        {
            var student = await _context.Students
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (student == null)
                throw new StudentNotFound();

            var entry = _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
