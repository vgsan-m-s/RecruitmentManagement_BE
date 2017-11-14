﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using RecruitmentM.Application;
using Microsoft.AspNetCore.Cors;

namespace RecruitmentM.Web.Host.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    [Produces("application/json")]
    [Route("api/Workflow")]
    public class WorkflowController : Controller
    {
        private readonly IMapper _mapper;
        IWorkflowService _workflowService;

        public WorkflowController(IMapper mapper,
            IWorkflowService workflowService)
        {
            _mapper = mapper;
            _workflowService = workflowService;
        }

        [HttpGet("GetWorkflows")]
        public List<WorkflowDto> GetWorkflows()
        {
            List<WorkflowDto> workflowList = _workflowService.GetWorkflows();
            return workflowList;
        }

        [HttpPost("CreateWorkflow")]
        public async Task CreateWorkflow(WorkflowInput input)
        {
            await _workflowService.CreateWorkflow(input);
        }

        [HttpPost("UpdateWorkflow")]
        public async Task UpdateWorkflow(WorkflowDto input)
        {
            await _workflowService.UpdateWorkflow(input);
        }
    }
}