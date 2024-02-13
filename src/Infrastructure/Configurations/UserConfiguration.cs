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

            builder.Property(u => u.IsBlocked)
                .HasDefaultValue(false);

            builder.Property(u => u.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            builder.Property(u => u.UpdatedAt)
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
        }
    }
}
