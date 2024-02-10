namespace Application.DataTransferObjects.Tasks
{
    public record class GradeCreationDTO
    (
        string Description,
        long TaskResultId,
        int Percent
    );
}
