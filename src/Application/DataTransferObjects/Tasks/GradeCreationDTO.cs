namespace Application.DataTransferObjects.Tasks
{
    public record GradeCreationDTO
    (
        string Description,
        long TaskResultId,
        int Percent
    );
}
