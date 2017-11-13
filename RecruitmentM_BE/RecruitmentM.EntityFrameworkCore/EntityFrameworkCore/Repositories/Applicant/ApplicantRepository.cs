using Microsoft.EntityFrameworkCore;
using RecruitmentM.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentM.EntityFrameworkCore.EntityFrameworkCore.Repositories.Applicant
{
    public class ApplicantRepository : GenericRepository<ApplicantEntity>, IApplicantRepository
    {
        public ApplicantRepository(RecruitmentMDbContext dbContext)
        : base(dbContext)
        {

        }

        public async Task<ApplicantEntity> GetApplicants()
        {
            return await GetAll()
                .OrderByDescending(c => c.Id)
                .FirstOrDefaultAsync();
        }
    }
}
