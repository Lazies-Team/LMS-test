namespace Application.ViewModel
{
    public record AdminViewModel(
        long Id,
        long UserId,
        DateTime CreatedAt,
        DateTime UpdatedDate
    );
}
