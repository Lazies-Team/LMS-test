using Domain.Comman;

namespace Domain.Entities.Users
{
    public class Student : Auditable
    {
        public long StudentKey { get; set; }
        public long UserId { get; set; }
    }
}
