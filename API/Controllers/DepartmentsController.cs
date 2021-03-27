using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository _depRepo;
        public DepartmentsController(IDepartmentRepository depRepo)
        {
            _depRepo = depRepo;

        }

        [HttpGet]
        public async Task<ActionResult<List<Department>>> GetDepartments()
        {
            return Ok(await _depRepo.GetDepartmentsAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetDepartment(int id)
        {
            return Ok(await _depRepo.GetDepartmentByIdAsync(id));
        }
    }
}