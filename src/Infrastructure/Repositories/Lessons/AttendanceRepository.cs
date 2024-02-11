using Application.Abstractions.Lessons;
using Domain.Entities.Lessons;
using Domain.Exceptions.Lesson;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Lessons
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly ApplicationDbContext _context;

        public AttendanceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async ValueTask<Attendance> DeleteAsync(long id)
        {
            Attendance? attendance = await _context.Attendances
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (attendance == null)
                throw new AttendanceNotFound();

            var entry = _context.Attendances.Remove(attendance);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async ValueTask<Attendance> InsertAsync(Attendance entity)
        {
            var entry = await _context.Attendances.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public IQueryable<Attendance> SelectAll()
        {
            IQueryable<Attendance> attendances = _context.Attendances.AsNoTracking();

            return attendances;
        }

        public async ValueTask<Attendance> SelectByIdAsync(long id)
        {
            Attendance? attendance = await _context.Attendances
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (attendance == null)
                throw new AttendanceNotFound();

            return attendance;
        }

        public async ValueTask<Attendance> UpdateAsync(Attendance entity)
        {
            Attendance? attendance = await _context.Attendances
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (attendance == null)
                throw new AttendanceNotFound();

            attendance = entity.Adapt(entity);
            var entry = _context.Attendances.Update(attendance);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}