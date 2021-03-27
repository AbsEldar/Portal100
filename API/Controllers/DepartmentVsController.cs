using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentVsController : ControllerBase
    {
        private readonly IDepartmentVRepository _depVRepo;
        public DepartmentVsController(IDepartmentVRepository depVRepo)
        {
            _depVRepo = depVRepo;

        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<DepartmentV>>> GetDepartmentVs()
        {
            return Ok(await _depVRepo.GetDepartmentVsAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DepartmentV>> GetDepartmentV(int id)
        {
            return Ok(await _depVRepo.GetDepartmentVByIdAsync(id));
        }
    }
}