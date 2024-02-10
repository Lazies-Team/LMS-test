namespace Application.DataTransferObjects.Users
{
    public record StudentModificationDTO
    (
        long Id,
        long StudentKey,
        long UserId
    );
}