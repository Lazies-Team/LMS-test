using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.ProfilePhotoPath)
            .HasDefaultValue(@"profile_photo/default_user.png");

            builder.HasOne(e => e.Admin)
                .WithOne(e => e.User)
                .HasForeignKey<Admin>(e => e.UserId)
                .IsRequired();

            builder.HasOne(e => e.Teacher)
                .WithOne(e => e.User)
                .HasForeignKey<Teacher>(e => e.UserId)
                .IsRequired();

            builder.HasOne(e => e.Student)
                .WithOne(e => e.User)
                .HasForeignKey<Student>(e => e.UserId)
                .IsRequired();
        }
    }
}
