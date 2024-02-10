namespace Application.DataTransferObjects.Tasks
{
    public record class GradeModificationDTO
    (
        long Id,
        string Description,
        long TaskResultId,
        int Percent
    );
}