using Application.Abstractions.Courses;
using Domain.Entities.Courses;
using Domain.Exceptions.Course;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Courses
{
    public class SpecialtyRepository : ISpecialtyRepository
    {
        private readonly ApplicationDbContext _context;

        public SpecialtyRepository(ApplicationDbContext context)
            => _context = context;

        public async ValueTask<Specialty> DeleteAsync(long id)
        {
            Specialty? specialty = await _context.Specialties
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (specialty == null)
                throw new SpecialtyNotFound();

            var entry = _context.Specialties.Remove(specialty);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async ValueTask<Specialty> InsertAsync(Specialty entity)
        {
            var entry = await _context.Specialties.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public IQueryable<Specialty> SelectAll()
        {
            IQueryable<Specialty> specialties = _context.Specialties.AsNoTracking();

            return specialties;
        }

        public async ValueTask<Specialty> SelectByIdAsync(long id)
        {
            Specialty? specialty = await _context.Specialties
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (specialty == null)
                throw new SpecialtyNotFound();

            return specialty;
        }

        public async ValueTask<Specialty> UpdateAsync(Specialty entity)
        {
            Specialty? specialty = await _context.Specialties
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (specialty == null)
                throw new SpecialtyNotFound();

            specialty = entity.Adapt(entity);
            var entry = _context.Specialties.Update(specialty);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
