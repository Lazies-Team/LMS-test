namespace Application.ViewModel.Users
{
    public record RoleViewModel(
        long Id,
        string Name,
        DateTime CreatedAt,
        DateTime UpdatedDate
    );
}
