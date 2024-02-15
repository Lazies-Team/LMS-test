using Application.Abstractions.Courses;
using Domain.Entities.Courses;
using Domain.Exceptions.Course;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Courses
{
    public class SpecialityRepository : ISpecialityRepository
    {
        private readonly ApplicationDbContext _context;

        public SpecialityRepository(ApplicationDbContext context)
            => _context = context;

        public async ValueTask<Speciality> DeleteAsync(long id)
        {
            Speciality? specialty = await _context.Specialities
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (specialty == null)
                throw new SpecialtyNotFound();

            var entry = _context.Specialities.Remove(specialty);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async ValueTask<Speciality> InsertAsync(Speciality entity)
        {
            var entry = await _context.Specialities.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public IQueryable<Speciality> SelectAll()
        {
            IQueryable<Speciality> specialties = _context.Specialities.AsNoTracking();

            return specialties;
        }

        public async ValueTask<Speciality> SelectByIdAsync(long id)
        {
            Speciality? specialty = await _context.Specialities
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (specialty == null)
                throw new SpecialtyNotFound();

            return specialty;
        }

        public async ValueTask<Speciality> UpdateAsync(Speciality entity)
        {
            Speciality? specialty = await _context.Specialities
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (specialty == null)
                throw new SpecialtyNotFound();

            specialty = entity.Adapt(specialty);
            var entry = _context.Specialities.Update(specialty);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
