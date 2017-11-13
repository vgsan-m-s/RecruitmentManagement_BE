using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RecruitmentM.Core
{
    [Table("Experience")]
    public class Experience : BaseEntity
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
