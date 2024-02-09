﻿using Domain.Comman;
using Domain.Entities.Users;

namespace Domain.Entities
{
    public class CourseTeacher : Auditable
    {
        public long CourseId { get; set; }
        public long TeacherId { get; set; }

        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
    }
}