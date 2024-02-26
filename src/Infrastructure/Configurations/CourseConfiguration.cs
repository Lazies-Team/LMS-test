using Domain.Entities;
using Domain.Entities.Courses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasOne(x => x.Specialty)
                .WithMany(x => x.Courses)
                .HasForeignKey(x => x.SpecialityId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Teachers)
                .WithMany(x => x.Courses)
                .UsingEntity(nameof(CourseTeacher));
        }
    }
}
