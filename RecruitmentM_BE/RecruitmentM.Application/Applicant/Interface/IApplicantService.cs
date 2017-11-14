using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentM.Application
{
    public interface IApplicantService
    {
        Task<ApplicantDto> GetApplicant(int id);
        List<ApplicantDto> GetApplicants();
        Task CreateApplicant(ApplicantInput input);
        Task UpdateApplicant(ApplicantDto input);
        Task DeleteApplicant(int id);
    }
}
