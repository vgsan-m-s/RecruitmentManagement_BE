using RecruitmentM.Application;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentM.Application
{
    public interface IExperienceService
    {
        List<ExperienceDto> GetExperiences();
        Task CreateExperience(ExperienceInput input);
        Task UpdateExperience(ExperienceDto input);
        Task DeleteExperience(int ExperienceId);
    }
}
