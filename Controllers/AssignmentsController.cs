using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssignmentsController : ControllerBase
    {

        private readonly DataContext _context;
        public AssignmentsController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppAssignment>>> GetAssignments()
        {
            var assignments = await _context.Assignments.ToListAsync();
            return assignments;
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<AppAssignment>> GetAssignment(int id)
        {
            return await _context.Assignments.FindAsync(id);
        }

    }
}