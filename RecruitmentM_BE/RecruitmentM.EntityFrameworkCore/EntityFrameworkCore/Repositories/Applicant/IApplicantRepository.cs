using RecruitmentM.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentM.EntityFrameworkCore.EntityFrameworkCore.Repositories.Applicant
{
    public interface IApplicantRepository : IGenericRepository<ApplicantEntity>
    {
        Task<ApplicantEntity> GetApplicants();
    }
}
