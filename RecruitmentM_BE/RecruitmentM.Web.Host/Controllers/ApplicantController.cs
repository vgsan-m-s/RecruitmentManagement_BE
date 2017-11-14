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
    [Route("api/Applicant")]
    public class ApplicantController : Controller
    {
        private readonly IMapper _mapper;
        IApplicantService _applicantService;

        public ApplicantController(IMapper mapper,
            IApplicantService applicantService)
        {
            _mapper = mapper;
            _applicantService = applicantService;
        }

        [HttpGet("GetApplicant")]
        public async Task<ApplicantDto> GetApplicant(int id)
        {
            ApplicantDto applicant = await _applicantService.GetApplicant(id);
            return applicant;
        }

        [HttpGet("GetApplicants")]
        public List<ApplicantDto> GetApplicants()
        {
            List<ApplicantDto> applicantList = _applicantService.GetApplicants();
            return applicantList;
        }

        [HttpPut("CreateApplicant")]
        public async Task CreateApplicant(ApplicantInput input)
        {
            await _applicantService.CreateApplicant(input);
        }

        [HttpPost("UpdateApplicant")]
        public async Task UpdateApplicant(ApplicantDto input)
        {
            await _applicantService.UpdateApplicant(input);
        }

        [HttpDelete("DeleteApplicant")]
        public async Task DeleteApplicant(int id)
        {
            await _applicantService.DeleteApplicant(id);
        }
    }
}