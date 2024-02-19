namespace Application.ViewModel.Users
{
    public record AdminViewModel(
        long Id,
        long UserId,
        DateTime CreatedAt,
        DateTime UpdatedDate
    );
}
