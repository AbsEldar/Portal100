using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly StoreContext _context;
        public DepartmentRepository(StoreContext context)
        {
            _context = context;

        }
        public async Task<Department> GetDepartmentByIdAsync(int id)
        {
            return await _context.Departments.FindAsync(id);
        }

        public async Task<IReadOnlyList<Department>> GetDepartmentsAsync()
        {
            return await _context.Departments
            .Include(x => x.DepartmentVs)
            .ToListAsync();
        }
    }
}