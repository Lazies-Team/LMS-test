using Domain.Enums;

namespace Application.DataTransferObjects.Users
{
    public record UserCreationDTO(
        string FirstName,
        string LastName,
        string PhoneNumber,
        DateTime BirthDate,
        Gender Gender,
        string Login,
        string Password,
        long RoleId
        );
}
