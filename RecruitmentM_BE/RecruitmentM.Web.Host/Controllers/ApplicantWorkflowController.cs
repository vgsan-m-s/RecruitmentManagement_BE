using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using AutoMapper;
using RecruitmentM.Application;

namespace RecruitmentM.Web.Host.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    [Produces("application/json")]
    [Route("api/ApplicantWorkflow")]
    public class ApplicantWorkflowController : Controller
    {
        private readonly IMapper _mapper;
        IApplicantWorkflowService _applicantWorkflowService;

        public ApplicantWorkflowController(IMapper mapper,
            IApplicantWorkflowService applicantWorkflowService)
        {
            _mapper = mapper;
            _applicantWorkflowService = applicantWorkflowService;
        }

        [HttpGet("GetApplicantWorkflows")]
        public List<ApplicantWorkflowDto> GetApplicantWorkflows(string ApplicantMailAddress)
        {
            List<ApplicantWorkflowDto> applicantWorkflowList = _applicantWorkflowService.GetApplicantWorkflows(ApplicantMailAddress);
            return applicantWorkflowList;
        }

        [HttpGet("GetApplicantCurrentState")]
        public List<ApplicantWorkflowDto> GetApplicantCurrentState()
        {
            List<ApplicantWorkflowDto> applicantWorkflowList = _applicantWorkflowService.GetApplicantCurrentState();
            return applicantWorkflowList;
        }

        [HttpPost("CreateApplicantWorkflow")]
        public async Task CreateWorkflow(ApplicantWorkflowInput input)
        {
            await _applicantWorkflowService.CreateApplicantWorkflow(input);
        }
    }
}