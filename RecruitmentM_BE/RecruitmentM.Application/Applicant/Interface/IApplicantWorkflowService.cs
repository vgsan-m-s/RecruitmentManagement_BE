using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentM.Application
{
    public interface IApplicantWorkflowService
    {
        List<ApplicantWorkflowDto> GetApplicantWorkflows();
        Task CreateApplicantWorkflow(ApplicantWorkflowInput input);
    }
}
