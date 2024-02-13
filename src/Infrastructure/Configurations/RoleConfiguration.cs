using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            builder.Property(x => x.UpdatedAt)
                .HasDefaultValue(DateTime.Now);

            builder.HasData(
                new List<Role>{
                    new Role()
                    {
                        Id = 1,
                        Name = "Student",
                    },
                    new Role()
                    {
                        Id = 2,
                        Name = "Teacher",
                    },
                    new Role()
                    {
                        Id = 3,
                        Name = "Admin",
                    }
                });
        }
    }
}
