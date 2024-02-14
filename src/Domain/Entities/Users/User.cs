using Domain.Comman;
using Domain.Enums;

namespace Domain.Entities.Users
{
    public class User : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string ProfilePhotoPath { get; set; }
        public Gender Gender { get; set; }
        public string Login { get; set; }
        public string Salt { get; set; }
        public string PasswordHash { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpireDate { get; set; }
        public long RoleId { get; set; }
        public bool IsBlocked { get; set; }

        public virtual Role Role { get; set; }
        public virtual Admin? Admin { get; set; }
        public virtual Teacher? Teacher { get; set; }
        public virtual Student? Student { get; set; }
    }
}
