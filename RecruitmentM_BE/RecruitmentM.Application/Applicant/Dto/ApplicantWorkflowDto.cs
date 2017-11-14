using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentM.Application
{
    public class ApplicantWorkflowDto
    {
        public int Id { get; set; }

        public int ApplicantId { get; set; }
        public ApplicantDto Applicant { get; set; }

        public int WorkflowId { get; set; }
        public WorkflowDto Workflow { get; set; }

        public DateTime ActionTime { get; set; }
    }

    public class ApplicantWorkflowInput
    {
        public int ApplicantId { get; set; }
        public int WorkflowId { get; set; }
    }
}
