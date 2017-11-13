using Microsoft.EntityFrameworkCore;
using RecruitmentM.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentM.EntityFrameworkCore.EntityFrameworkCore
{
    public class RecruitmentMDbContext : DbContext
    {
        /* Define an IDbSet for each entity of the application */

        public virtual DbSet<ApplicantEntity> Applicant { get; set; }

        public RecruitmentMDbContext(DbContextOptions<RecruitmentMDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
