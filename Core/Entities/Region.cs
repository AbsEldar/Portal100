using System.Collections.Generic;

namespace Core.Entities
{
    public class Region: BaseEntity
    {
        public string NameRu { get; set; }
        public string NameEn { get; set; }
        public string NameKz { get; set; }
        public virtual ICollection<DepartmentV> DepartmentVs { get; set; }
    }
}