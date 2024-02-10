namespace Domain.Exceptions.Video
{
    public class VideoNotFound : GlobalException
    {
        public VideoNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Video Not Found !";
        }
    }
}