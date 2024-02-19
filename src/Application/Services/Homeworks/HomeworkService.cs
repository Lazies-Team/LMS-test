using Application.Abstractions.Homeworks;
using Application.DataTransferObjects.HomeWorks;
using Application.Services.Contracts.Homeworks;
using Application.ViewModel;
using Domain.Entities.Homeworks;
using Domain.Exceptions.HomeWork;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Homeworks
{
    public class HomeworkService : IHomeworkService
    {
        private readonly IHomeworkRepository _homeworkRepository;

        public HomeworkService(IHomeworkRepository homeworkRepository)
            => _homeworkRepository = homeworkRepository;      

        public async ValueTask<HomeworkViewModel> AddAsync(HomeworkCreationDTO homeworkCreationDTO)
        {
            var homework = homeworkCreationDTO.Adapt<Homework>();
            var created =  await _homeworkRepository.InsertAsync(homework);
            var homeworkViewModel = created.Adapt<HomeworkViewModel>();

            return homeworkViewModel;
        }

        public async ValueTask<List<HomeworkViewModel>> GetAllAsync()
        {
            var homeworks = _homeworkRepository.SelectAll();
            var homeworklist = homeworks.ToList().Adapt<List<HomeworkViewModel>>();

            return homeworklist;
        }

        public async ValueTask<HomeworkViewModel> GetByIdAsync(long id)
        {
            var homework = await _homeworkRepository.SelectByIdAsync(id);
            var homeworkviewmodel = homework.Adapt<HomeworkViewModel>();

            return homeworkviewmodel;
        }

        public async ValueTask<HomeworkViewModel> UpdateAsync(HomeworkModificationDTO homeworkModificationDTO, long id)
        {
            var homework = homeworkModificationDTO.Adapt<Homework>();
            homework.Id = id;
            var updated = await _homeworkRepository.UpdateAsync(homework);
            var result = updated.Adapt<HomeworkViewModel>();

            return result;
        }

        public async ValueTask<HomeworkViewModel> DeleteAsync(long id)
        {
            var deleted = _homeworkRepository.DeleteAsync(id);
            var homework = deleted.Adapt<HomeworkViewModel>();

            return homework;
        }
    }
}
