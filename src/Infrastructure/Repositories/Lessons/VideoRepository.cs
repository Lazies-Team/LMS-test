using Application.Abstractions.Lessons;
using Domain.Entities.Lessons;
using Domain.Exceptions.Video;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Lessons
{
    public class VideoRepository : IVideoRepository
    {
        private readonly ApplicationDbContext _context;

        public VideoRepository(ApplicationDbContext context)
            => _context = context;

        public async ValueTask<Video> DeleteAsync(long id)
        {
            Video? video = await _context.Videos
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (video == null)
                throw new VideoNotFound();

            var entry = _context.Videos.Remove(video);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async ValueTask<Video> InsertAsync(Video entity)
        {
            var entry = await _context.Videos.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public IQueryable<Video> SelectAll()
        {
            IQueryable<Video> videos = _context.Videos.AsNoTracking();

            return videos;
        }

        public async ValueTask<Video> SelectByIdAsync(long id)
        {
            var video = await _context.Videos
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (video == null)
                throw new VideoNotFound();

            return video;
        }

        public async ValueTask<Video> UpdateAsync(Video entity)
        {
            var video = await _context.Videos
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (video == null)
                throw new VideoNotFound();

            video = entity.Adapt(video);
            var entry = _context.Videos.Update(video);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
