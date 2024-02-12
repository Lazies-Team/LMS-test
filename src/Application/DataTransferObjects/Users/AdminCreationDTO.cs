using Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.Text.Json.Serialization;

namespace Application.DataTransferObjects.Users
{
    public record AdminCreationDTO
    (
        long UserId
    );
}