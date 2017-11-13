using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentM.Core
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }

        public BaseEntity()
        {
            AddedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
            IsActive = true;
        }
    }
}
