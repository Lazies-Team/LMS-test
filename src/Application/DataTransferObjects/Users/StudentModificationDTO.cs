namespace Application.DataTransferObjects.Users
{
    public record class StudentModificationDTO
    (
        long Id,
        long StudentKey,
        long UserId
    );
}