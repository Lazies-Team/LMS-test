﻿using Domain.Enums;

namespace Application.ViewModel.Users
{
    public record UserViewModel(
        long Id,
        string FirstName,
        string LastName,
        string PhoneNumber,
        DateTime BirthDate,
        string ProfilePhotoPath,
        Gender Gender,
        string Login,
        RoleViewModel Role,
        DateTime CreatedAt,
        DateTime UpdatedDate,
        AdminViewModel Admin,
        StudentViewModel Student,
        TeacherViewModel Teacher
    );

}