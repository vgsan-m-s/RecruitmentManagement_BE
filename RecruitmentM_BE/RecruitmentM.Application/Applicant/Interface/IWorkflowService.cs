using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentM.Application
{
    public interface IWorkflowService
    {
        List<WorkflowDto> GetWorkflows();
        Task CreateWorkflow(WorkflowInput input);
        Task UpdateWorkflow(WorkflowDto input);
    }
}
