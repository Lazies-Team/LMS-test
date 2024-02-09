using System.Net;

namespace Domain.Exceptions
{
    public class GlobalException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }
        public string TitleMessage { get; set; } = string.Empty;
    }
}