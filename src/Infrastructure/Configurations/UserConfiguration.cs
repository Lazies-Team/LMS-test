using Domain.Entities.Users;
using Domain.Enums;
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

            builder.Property(u => u.IsBlocked)
                .HasDefaultValue(false);

            builder.HasData(
            new User
            {
                Id = 1,
                FirstName = "Sarvar",
                LastName = "G'ulomjonov",
                PhoneNumber = "+998950940303",
                BirthDate = new DateTime(2003, 05, 10),
                ProfilePhotoPath = @"profile_photo/murodovich.png",
                Gender = Gender.Male,
                Login = "murodovich",
                Salt = "sarvar",
                PasswordHash = "5605b79792f56859005103910bca2de67beb3c924f64138442eee5734e315344",
                RefreshToken = "bir nima",
                RefreshTokenExpireDate = DateTime.Now.AddDays(1),
                RoleId = 3,
                IsBlocked = false
            });

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
