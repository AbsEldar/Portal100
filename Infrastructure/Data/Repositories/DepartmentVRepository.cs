using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
    public class DepartmentVRepository : IDepartmentVRepository
    {
        private readonly StoreContext _context;
        public DepartmentVRepository(StoreContext context)
        {
            _context = context;

        }
        public async Task<DepartmentV> GetDepartmentVByIdAsync(int id)
        {
            return await _context.DepartmentVs.FindAsync(id);
        }

        public async Task<IReadOnlyList<DepartmentV>> GetDepartmentVsAsync()
        {
            return await _context.DepartmentVs.ToListAsync();
        }
    }
}