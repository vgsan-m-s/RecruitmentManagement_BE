using AutoMapper;
using RecruitmentM.Application;
using RecruitmentM.Core;
using RecruitmentM.EntityFrameworkCore;
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
            List<Applicant> listOfApplicant = _applicantrepository.GetAll().ToList();
            var result = _mapper.Map<List<ApplicantDto>>(listOfApplicant);

            return result;
        }

        public async Task CreateApplicant(ApplicantInput input)
        {
            Applicant result = _mapper.Map<Applicant>(input);
            await _applicantrepository.Create(result);
        }

        public async Task UpdateApplicant(ApplicantDto input)
        {
            Applicant result = _mapper.Map<Applicant>(input);
            result.ModifiedDate = DateTime.Now;

            await _applicantrepository.Update(input.Id, result);
        }

        public async Task<ApplicantDto> GetApplicant(int id)
        {
            Applicant applicant = await _applicantrepository.GetById(id);
            var result = _mapper.Map<ApplicantDto>(applicant);
            return result;
        }

        public async Task DeleteApplicant(int id)
        {
            await _applicantrepository.Delete(id);
        }
    }
}
