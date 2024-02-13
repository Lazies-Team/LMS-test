using Domain.Entities.Users;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;

namespace Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.ProfilePhotoPath)
                .HasDefaultValue(@"profile_photo/default_user.png");

            builder.Property(u => u.FirstName)
                .IsRequired();

            builder.Property(u => u.LastName)
                .IsRequired();

            builder.Property(u => u.PhoneNumber)
                 .IsRequired();

            builder.Property(u => u.BirthDate)
                .IsRequired();

            builder.Property(u => u.Gender)
                .IsRequired();

            builder.Property(u => u.Login)
                .IsRequired();

            builder.Property(u => u.Salt)
                .IsRequired();

            builder.Property(u => u.PasswordHash)
                .IsRequired();

            builder.Property(u => u.RefreshToken)
                .IsRequired();

            builder.Property(u => u.RefreshTokenExpireDate)
                .IsRequired();

            builder.Property(u => u.RoleId)
                .IsRequired();

            builder.Property(u => u.IsBlocked)
                .HasDefaultValue(false);

            builder.Property(u => u.CreatedAt)
                .IsRequired()
                .HasDefaultValue(DateTime.Now);

            builder.Property(u => u.UpdatedAt)
                .IsRequired()
                .HasDefaultValue(DateTime.Now);

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
                PasswordHash = "sarvar0303",
                RefreshToken = "bir nima",
                RefreshTokenExpireDate = DateTime.Now.AddDays(1),
                RoleId = 3,
                IsBlocked = false
            });

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
        }
    }
}
