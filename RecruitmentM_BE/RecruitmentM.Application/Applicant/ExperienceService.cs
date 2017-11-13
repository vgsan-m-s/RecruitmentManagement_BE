using AutoMapper;
using RecruitmentM.Core;
using RecruitmentM.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentM.Application
{
    public class ExperienceService : IExperienceService
    {
        private readonly IMapper _mapper;
        IGenericRepository<Experience> _experienceRepository;

        public ExperienceService(IMapper mapper,
            IGenericRepository<Experience> experienceRepository)
        {
            _mapper = mapper;
            _experienceRepository = experienceRepository;
        }

        public async Task CreateExperience(ExperienceInput input)
        {
            Experience result = _mapper.Map<Experience>(input);
            await _experienceRepository.Create(result);
        }

        public async Task DeleteExperience(int ExperienceId)
        {
            await _experienceRepository.Delete(ExperienceId);
        }

        public List<ExperienceDto> GetExperiences()
        {
            List<Experience> listOfExperince = _experienceRepository.GetAll().ToList();
            var result = _mapper.Map<List<ExperienceDto>>(listOfExperince);

            return result;
        }

        public async Task UpdateExperience(ExperienceDto input)
        {
            Experience result = _mapper.Map<Experience>(input);
            result.ModifiedDate = DateTime.Now;

            await _experienceRepository.Update(input.Id, result);
        }
    }
}
