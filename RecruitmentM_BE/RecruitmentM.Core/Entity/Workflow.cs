using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RecruitmentM.Core
{
    [Table("Workflow")]
    public class Workflow : BaseEntity
    {
        public string ProcessName { get; set; }
        public int ProcessOrder { get; set; }
    }
}
