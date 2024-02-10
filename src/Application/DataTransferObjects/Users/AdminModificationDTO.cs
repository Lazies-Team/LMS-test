﻿using Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace Application.DataTransferObjects.Users
{
    public record class AdminModificationDTO
    (
        long Id,
        long UserId
    );
}