﻿using Domain.Entities.Courses;
using Domain.Entities.Users;

namespace Application.ViewModel
{
    public record TeacherViewModel
    (
        long Id,
        DateTime CreatedAt,
        DateTime UpdatedDate,
        long UserId,
        ICollection<Course> Courses
    );
}