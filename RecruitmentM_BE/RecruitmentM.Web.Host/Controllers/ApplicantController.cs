using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecruitmentM.Application;
using AutoMapper;

namespace RecruitmentM.Web.Host.Controllers
{
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

        [HttpGet("GetApplicants")]
        public List<ApplicantDto> GetApplicants()
        {
            List<ApplicantDto> applicantList = _applicantService.GetApplicants();
            return applicantList;
        }

        [HttpGet("GetApplicantsTest")]
        public List<ApplicantDto> GetApplicantsTest()
        {
            List<ApplicantDto> applicantList = _applicantService.GetApplicants();
            return applicantList;
        }
    }
}