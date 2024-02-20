using Domain.Entities.Homeworks;

namespace Application.ViewModel.Homeworks
{
    public record HomeworkFileViewModel
    (
       long HomeworkId,
       string filepath,
       DateTime CreatedAt,
       DateTime UpdatedDate,
       Homework Homework
    );
}
