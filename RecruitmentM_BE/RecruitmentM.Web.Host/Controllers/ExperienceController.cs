using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecruitmentM.Application;
using AutoMapper;
using Microsoft.AspNetCore.Cors;

namespace RecruitmentM.Web.Host.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    [Produces("application/json")]
    [Route("api/Experience")]
    public class ExperienceController : Controller
    {
        private readonly IMapper _mapper;
        IExperienceService _experienceService;

        public ExperienceController(IMapper mapper,
            IExperienceService experienceService)
        {
            _mapper = mapper;
            _experienceService = experienceService;
        }

        [HttpGet("GetExperiences")]
        public List<ExperienceDto> GetExperiences()
        {
            List<ExperienceDto> experienceList = _experienceService.GetExperiences();
            return experienceList;
        }

        [HttpPost("CreateExperience")]
        public async Task CreateExperience(ExperienceInput input)
        {
            await _experienceService.CreateExperience(input);
        }

        [HttpPost("UpdateExperience")]
        public async Task UpdateExperience(ExperienceDto input)
        {
            await _experienceService.UpdateExperience(input);
        }

        [HttpPost("DeleteExperience")]
        public async Task DeleteExperience(int ExperienceId)
        {
            await _experienceService.DeleteExperience(ExperienceId);
        }
    }
}