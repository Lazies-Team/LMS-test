﻿using Domain.Comman;
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
        public string PasswordHash { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpireDate { get; set; }
        public long RoleId { get; set; }

        public Role Role { get; set; }
    }
}
