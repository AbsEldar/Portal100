using System;

namespace Core.Entities
{
    public class DepartmentV: BaseEntity
    {
        public DateTime Created { get; set; }
        // public string Author { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public string DisplayNameRus { get; set; }
        public string DisplayNameEng { get; set; }
        public string DisplayNameKaz { get; set; }

        public string FromNameRus { get; set; }
        public string FromNameEng { get; set; }
        public string FromNameKaz { get; set; }


        public string ToNameRus { get; set; }
        public string ToNameEng { get; set; }
        public string ToNameKaz { get; set; }

        public int Priority { get; set; }
        public bool Disabled { get; set; }
        
        public int? RegionId { get; set; }
        public virtual Region Region { get; set; }
       
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}