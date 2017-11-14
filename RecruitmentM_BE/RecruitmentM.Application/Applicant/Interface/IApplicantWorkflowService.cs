using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentM.Application
{
    public interface IApplicantWorkflowService
    {
        List<ApplicantWorkflowDto> GetApplicantWorkflows(string ApplicantMailAddress);
        List<ApplicantWorkflowDto> GetApplicantCurrentState();
        Task CreateApplicantWorkflow(ApplicantWorkflowInput input);
    }
}
