namespace Application.DataTransferObjects.Tasks
{
    public record GradeModificationDTO
    (
        long Id,
        string Description,
        long TaskResultId,
        int Percent
    );
}