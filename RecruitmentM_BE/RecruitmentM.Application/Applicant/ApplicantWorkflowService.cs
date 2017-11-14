using AutoMapper;
using RecruitmentM.Core;
using RecruitmentM.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentM.Application
{
    public class ApplicantWorkflowService : IApplicantWorkflowService
    {
        private readonly IMapper _mapper;
        IGenericRepository<ApplicantWorkflow> _applicantWorkflowRepository;
        IGenericRepository<Applicant> _applicantRepository;
        IGenericRepository<Workflow> _workflowRepository;

        public ApplicantWorkflowService(IMapper mapper,
            IGenericRepository<ApplicantWorkflow> applicantWorkflowRepository,
            IGenericRepository<Applicant> applicantRepository,
            IGenericRepository<Workflow> workflowRepository)
        {
            _mapper = mapper;
            _applicantWorkflowRepository = applicantWorkflowRepository;
            _applicantRepository = applicantRepository;
            _workflowRepository = workflowRepository;
        }

        public async Task CreateApplicantWorkflow(ApplicantWorkflowInput input)
        {
            ApplicantWorkflow result = _mapper.Map<ApplicantWorkflow>(input);
            await _applicantWorkflowRepository.Create(result);
        }

        public List<ApplicantWorkflowDto> GetApplicantWorkflows(string ApplicantMailAddress)
        {
            Applicant apl = _applicantRepository.GetAll().Where(c => c.MailAddress == ApplicantMailAddress).SingleOrDefault();

            if (apl == null)
                return new List<ApplicantWorkflowDto>();

            List<ApplicantWorkflow> listOfWorkflow = _applicantWorkflowRepository.GetAll()
                .Where(c => c.ApplicantId == apl.Id).OrderBy(c => c.ActionTime).ToList();

            foreach (ApplicantWorkflow apwrlflw in listOfWorkflow)
            {
                apwrlflw.Applicant = _applicantRepository.GetById(apwrlflw.ApplicantId);
                apwrlflw.Workflow = _workflowRepository.GetById(apwrlflw.WorkflowId);
            }

            var result = _mapper.Map<List<ApplicantWorkflowDto>>(listOfWorkflow);

            return result;
        }

        public List<ApplicantWorkflowDto> GetApplicantCurrentState()
        {
            List<ApplicantWorkflow> listOfWorkflow = _applicantWorkflowRepository.GetAll()
                .GroupBy(m => m.ApplicantId).Select(g => g.OrderByDescending(x => x.ActionTime)
                .First()).ToList();

            foreach (ApplicantWorkflow apwrlflw in listOfWorkflow)
            {
                apwrlflw.Applicant = _applicantRepository.GetById(apwrlflw.ApplicantId);
                apwrlflw.Workflow = _workflowRepository.GetById(apwrlflw.WorkflowId);
            }

            //Get New Applicant
            var query = from app in _applicantRepository.GetAll()
                        join appWrk in _applicantWorkflowRepository.GetAll()
                            on app.Id equals appWrk.ApplicantId into pp
                        from appWrk in pp.DefaultIfEmpty()
                        where appWrk == null
                        select app;
            List<Applicant> newApplicantList = query.ToList();

            foreach (Applicant newApp in newApplicantList)
            {
                listOfWorkflow.Add(new ApplicantWorkflow
                {
                    Id = 0,
                    ActionTime = newApp.ModifiedDate,
                    AddedDate = newApp.AddedDate,
                    ModifiedDate = newApp.ModifiedDate,
                    Applicant = newApp,
                    ApplicantId = newApp.Id,
                    Workflow = new Workflow(),
                    WorkflowId = 0,
                    IsActive = true
                });
            }

            var result = _mapper.Map<List<ApplicantWorkflowDto>>(listOfWorkflow);

            return result;
        }
    }

}
