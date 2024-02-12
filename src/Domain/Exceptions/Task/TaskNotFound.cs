namespace Domain.Exceptions.Task
{
    public class TaskNotFound : GlobalException
    {
        public TaskNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Task Not Found !";
        }
    }
}