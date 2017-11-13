using RecruitmentM.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentM.EntityFrameworkCore
{
    public interface IApplicantRepository : IGenericRepository<Applicant>
    {
        Task<Applicant> GetApplicants();
    }
}
