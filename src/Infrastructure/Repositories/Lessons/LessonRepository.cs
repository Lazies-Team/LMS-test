using Application.Abstractions.Lessons;
using Domain.Entities.Lessons;
using Domain.Exceptions.Lesson;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Lessons
{
    public class LessonRepository : ILessonRepository
    {
        private readonly ApplicationDbContext _context;

        public LessonRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async ValueTask<Lesson> DeleteAsync(long id)
        {
            Lesson? lesson = await _context.Lessons
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (lesson == null)
                throw new LessonNotFound();

            var entry = _context.Lessons.Remove(lesson);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async ValueTask<Lesson> InsertAsync(Lesson entity)
        {
            var entry = await _context.Lessons.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public IQueryable<Lesson> SelectAll()
        {
            IQueryable<Lesson> lessons = _context.Lessons.AsNoTracking();

            return lessons;
        }

        public async ValueTask<Lesson> SelectByIdAsync(long id)
        {
            var lesson = await _context.Lessons
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (lesson == null)
                throw new LessonNotFound();

            return lesson;
        }

        public async ValueTask<Lesson> UpdateAsync(Lesson entity)
        {
            var lesson = await _context.Lessons
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (lesson == null)
                throw new LessonNotFound();

            lesson = entity.Adapt(lesson);
            var entry = _context.Lessons.Update(lesson);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}