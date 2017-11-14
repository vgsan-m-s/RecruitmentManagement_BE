using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentM.Application
{
    public interface IWorkflowService
    {
        Task<WorkflowDto> GetWorkflow(int id);
        List<WorkflowDto> GetWorkflows();
        Task CreateWorkflow(WorkflowInput input);
        Task UpdateWorkflow(WorkflowDto input);
        Task DeleteWorkflow(int id);
    }
}
