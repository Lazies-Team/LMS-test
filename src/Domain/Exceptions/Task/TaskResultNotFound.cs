namespace Domain.Exceptions.Task
{
    public class TaskResultNotFound : GlobalException
    {
        public TaskResultNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Task Result Not Found !";
        }
    }
}