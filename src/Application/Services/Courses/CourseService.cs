using Application.Abstractions.Courses;
using Application.Abstractions.Users;
using Application.DataTransferObjects.Courses;
using Application.Services.Contracts.Courses;
using Application.ViewModel.Courses;
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

        public async ValueTask<CourseViewModel> AddAsync(CourseCreationDTO courseCreationDTO)
        {
            var course = courseCreationDTO.Adapt<Course>();

            var teachers = _teacherRepository.SelectAll(courseCreationDTO.Teachers).ToList();
            course.Teachers = teachers;

            var result = await _courseRepository.InsertAsync(course);
            var courseViewModel = result.Adapt<CourseViewModel>();

            return courseViewModel;
        }

        public async ValueTask<CourseViewModel> DeleteAsync(long id)
        {
            var result = await _courseRepository.DeleteAsync(id);
            var courseViewModel = result.Adapt<CourseViewModel>();

            return courseViewModel;
        }

        public async ValueTask<List<CourseViewModel>> GetAllAsync()
        {
            var results = _courseRepository.SelectAll();
            var courseViewModel = results.Adapt<List<CourseViewModel>>();

            return courseViewModel;
        }

        public async ValueTask<CourseViewModel> GetByIdAsync(long id)
        {
            var result = await _courseRepository.SelectByIdAsync(id);
            var courseViewModel = result.Adapt<CourseViewModel>();

            return courseViewModel;
        }

        public async ValueTask<CourseViewModel> UpdateAsync(CourseModificationDTO courseModificationDTO, long id)
        {
            var course = courseModificationDTO.Adapt<Course>();
            course.Id = id;

            var result = await _courseRepository.UpdateAsync(course);
            var courseViewModel = result.Adapt<CourseViewModel>();

            return courseViewModel;
        }
    }
}
