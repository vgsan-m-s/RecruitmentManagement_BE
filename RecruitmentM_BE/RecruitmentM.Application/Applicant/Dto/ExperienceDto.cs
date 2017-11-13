using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentM.Application
{
    public class ExperienceDto
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public string CompanyName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Designation { get; set; }
        public string CompanyWebsite { get; set; }
        public string Projects { get; set; }
        public string Technologies { get; set; }
    }

    public class ExperienceInput
    {
        public int ApplicantId { get; set; }
        public string CompanyName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Designation { get; set; }
        public string CompanyWebsite { get; set; }
        public string Projects { get; set; }
        public string Technologies { get; set; }
    }
}
