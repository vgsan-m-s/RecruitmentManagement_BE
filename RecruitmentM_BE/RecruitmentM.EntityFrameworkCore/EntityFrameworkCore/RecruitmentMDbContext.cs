using Microsoft.EntityFrameworkCore;
using RecruitmentM.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentM.EntityFrameworkCore
{
    public class RecruitmentMDbContext : DbContext
    {
        /* Define an IDbSet for each entity of the application */

        public virtual DbSet<Applicant> Applicant { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }

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
