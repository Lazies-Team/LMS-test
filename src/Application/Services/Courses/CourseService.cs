using Application.Abstractions.Courses;
using Application.Abstractions.Users;
using Application.DataTransferObjects.Courses;
using Application.Services.Contracts.Courses;
using Domain.Entities.Courses;
using Mapster;

namespace Application.Services.Courses
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ITeacherRepository _teacherRepository;
        public CourseService(
            ICourseRepository courseRepository,
            ITeacherRepository teacherRepository)
        {
            _courseRepository = courseRepository;
            _teacherRepository = teacherRepository;
        }

        public async ValueTask<Course> AddAsync(CourseCreationDTO courseCreationDTO)
        {
            var course = courseCreationDTO.Adapt<Course>();

            var teachers = _teacherRepository.SelectAll(courseCreationDTO.Teachers).ToList();
            course.Teachers = teachers;

            var courseResult = await _courseRepository.InsertAsync(course);

            return courseResult;
        }

        public async ValueTask<Course> DeleteAsync(long id)
        {
            var course = await _courseRepository.DeleteAsync(id);

            return course;
        }

        public async ValueTask<List<Course>> GetAllAsync()
        {
            var results = _courseRepository.SelectAll().ToList();

            return results;
        }

        public async ValueTask<Course> GetByIdAsync(long id)
        {
            var course = await _courseRepository.SelectByIdAsync(id);

            return course;
        }

        public async ValueTask<Course> UpdateAsync(CourseModificationDTO courseModificationDTO, long id)
        {
            var course = courseModificationDTO.Adapt<Course>();
            course.Id = id;

            var result = await _courseRepository.UpdateAsync(course);

            return result;
        }
    }
}
