using System.Collections.Generic;

namespace Core.Entities
{
    public class Department: BaseEntity
    {
        public string KeyIndex { get; set; }
        public string MainIndex { get; set; }
        public virtual ICollection<DepartmentV> DepartmentVs { get; set; }
    }
}