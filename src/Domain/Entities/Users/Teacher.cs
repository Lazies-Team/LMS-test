using Domain.Comman;

namespace Domain.Entities.Users
{
    public class Teacher : Auditable
    {
        public long UserId { get; set; }
    }
}
