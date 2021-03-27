using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly StoreContext _context;
        public RegionRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task<Region> GetRegionByIdAsync(int id)
        {
            return await _context.Regions.FindAsync(id);
        }

        public async Task<IReadOnlyList<Region>> GetRegionsAsync()
        {
            return await _context.Regions.ToListAsync();
        }
    }
}