using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentM.Application
{
    public class ApplicantDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Status { get; set; }
    }
}
