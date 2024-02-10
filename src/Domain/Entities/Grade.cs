using Domain.Comman;
using Domain.Entities.Users;

namespace Domain.Entities
{
    public class Grade : Auditable
    {
        public string Description { get; set; }
        public long UserId { get; set; }
        public long TaskResultId { get; set; }
        public int Percent { get; set; }

        public User User { get; set; }
        public TaskResult TaskResult { get; set; }
    }
}
