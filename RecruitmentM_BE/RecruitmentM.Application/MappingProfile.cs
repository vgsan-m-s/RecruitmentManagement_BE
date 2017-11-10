using AutoMapper;
using RecruitmentM.Core.Entity;
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
        }
    }
}
