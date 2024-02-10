namespace Application.DataTransferObjects.Tasks
{
    public record GradeModificationDTO
    (
        string Description,
        long TaskResultId,
        int Percent
    );
}