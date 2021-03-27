using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IDepartmentVRepository
    {
         Task<DepartmentV> GetDepartmentVByIdAsync(int id);
         Task<IReadOnlyList<DepartmentV>> GetDepartmentVsAsync();
    }
}