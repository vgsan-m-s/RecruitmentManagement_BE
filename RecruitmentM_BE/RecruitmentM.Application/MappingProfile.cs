using AutoMapper;
using RecruitmentM.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentM.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Applicant, ApplicantDto>()
                .ReverseMap();
            CreateMap<Applicant, ApplicantInput>()
                .ReverseMap();

            CreateMap<Experience, ExperienceDto>()
                .ReverseMap();
            CreateMap<Experience, ExperienceInput>()
                .ReverseMap();

            CreateMap<Workflow, WorkflowDto>()
                .ReverseMap();
            CreateMap<Workflow, WorkflowInput>()
                .ReverseMap();

            CreateMap<ApplicantWorkflow, ApplicantWorkflowDto>()
                .ReverseMap();
            CreateMap<ApplicantWorkflow, ApplicantWorkflowInput>()
                .ReverseMap();
        }
    }
}
