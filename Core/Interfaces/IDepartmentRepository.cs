using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IDepartmentRepository
    {
         Task<Department> GetDepartmentByIdAsync(int id);
         Task<IReadOnlyList<Department>> GetDepartmentsAsync();
    }
}