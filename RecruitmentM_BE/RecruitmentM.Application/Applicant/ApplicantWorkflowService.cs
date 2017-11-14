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

        public ApplicantWorkflowService(IMapper mapper,
            IGenericRepository<ApplicantWorkflow> applicantWorkflowRepository)
        {
            _mapper = mapper;
            _applicantWorkflowRepository = applicantWorkflowRepository;
        }

        public async Task CreateApplicantWorkflow(ApplicantWorkflowInput input)
        {
            ApplicantWorkflow result = _mapper.Map<ApplicantWorkflow>(input);
            await _applicantWorkflowRepository.Create(result);
        }

        public List<ApplicantWorkflowDto> GetApplicantWorkflows()
        {
            List<ApplicantWorkflow> listOfWorkflow = _applicantWorkflowRepository.GetAll().ToList();
            var result = _mapper.Map<List<ApplicantWorkflowDto>>(listOfWorkflow);

            return result;
        }
    }

}
