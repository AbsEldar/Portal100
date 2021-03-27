using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IRegionRepository
    {
         Task<Region> GetRegionByIdAsync(int id);
         Task<IReadOnlyList<Region>> GetRegionsAsync();
    }
}