﻿using Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.Users
{
    public record UserModificationDTO(
        string FirstName,
        string LastName,
        string PhoneNumber,
        DateTime BirthDate,
        IFormFile ProfilePhoto,
        Gender Gender,
        string Login,
        string Password,
        long RoleId
        );
}
