namespace Application.ViewModel
{
    public record RoleViewModel(
        long Id,
        string Name,
        DateTime CreatedAt,
        DateTime UpdatedDate
    );
}
