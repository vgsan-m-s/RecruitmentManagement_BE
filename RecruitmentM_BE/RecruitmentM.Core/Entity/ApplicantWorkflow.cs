using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RecruitmentM.Core
{
    [Table("ApplicantWorkflow")]
    public class ApplicantWorkflow : BaseEntity
    {
        public int ApplicantId { get; set; }
        public Applicant Applicant { get; set; }

        public int WorkflowId { get; set; }
        public Workflow Workflow { get; set; }

        public DateTime ActionTime { get; set; }

        public ApplicantWorkflow()
        {
            ActionTime = DateTime.Now;
        }
    }
}
