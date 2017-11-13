using AutoMapper;
using RecruitmentM.Application;
using RecruitmentM.Core.Entity;
using RecruitmentM.EntityFrameworkCore.EntityFrameworkCore.Repositories.Applicant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentM.Application
{
    public class ApplicantService : IApplicantService
    {
        private readonly IMapper _mapper;
        IApplicantRepository _applicantrepository;

        public ApplicantService(IMapper mapper,
            IApplicantRepository applicantrepository)
        {
            _mapper = mapper;
            _applicantrepository = applicantrepository;
        }

        public List<ApplicantDto> GetApplicants()
        {
            List<ApplicantEntity> listOfApplicant = _applicantrepository.GetAll().ToList();
            var result = _mapper.Map<List<ApplicantDto>>(listOfApplicant);

            return result;
        }
    }
}
