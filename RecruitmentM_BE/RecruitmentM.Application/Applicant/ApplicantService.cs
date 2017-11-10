using AutoMapper;
using RecruitmentM.Application;
using RecruitmentM.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentM.Application
{
    public class ApplicantService : IApplicantService
    {
        private readonly IMapper _mapper;
        IRepository<Applicant> _applicantrepository;

        public ApplicantService(IMapper _mapper,
            IRepository<Applicant> applicantrepository)
        {
            _mapper = _mapper;
            _applicantrepository = applicantrepository;
        }

        public async Task<List<ApplicantDto>> GetApplicants()
        {
            //_applicantrepository.Get
            List<Applicant> listOfApplicant = new List<Applicant>();
            var result = _mapper.Map<List<ApplicantDto>>(listOfApplicant);

            return result;
        }
    }
}
