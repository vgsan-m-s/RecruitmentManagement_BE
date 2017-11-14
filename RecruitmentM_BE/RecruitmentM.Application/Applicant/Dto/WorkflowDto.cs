using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentM.Application
{
    public class WorkflowDto
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int ProcessOrder { get; set; }
    }

    public class WorkflowInput
    {
        public string ProcessName { get; set; }
        public int ProcessOrder { get; set; }
    }
}
