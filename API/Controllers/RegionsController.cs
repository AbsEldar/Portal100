using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegionsController : ControllerBase
    {
        private readonly IRegionRepository _regionRepo;
        public RegionsController(IRegionRepository regionRepo)
        {
            _regionRepo = regionRepo;

        }

        [HttpGet]
        public async Task<ActionResult<List<Region>>> GetRegions()
        {
            return Ok(await _regionRepo.GetRegionsAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Region>> GetRegion(int id)
        {
            return Ok(await _regionRepo.GetRegionByIdAsync(id));
        }
    }
}