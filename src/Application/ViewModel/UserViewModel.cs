using Domain.Entities.Users;
using Domain.Enums;

namespace Application.ViewModel
{
    public record UserViewModel(
        long Id,
        string FirstName,
        string LastNam,
        string PhoneNumber,
        DateTime BirthDate,
        string ProfilePhotoPath,
        Gender Gender,
        string Login,
        Role Role,
        DateTime CreatedAt,
        DateTime UpdatedDate
        );
}
