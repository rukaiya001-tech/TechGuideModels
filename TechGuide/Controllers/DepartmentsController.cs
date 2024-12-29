using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechGuide.Models;

namespace TechGuide.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly TechGuideDbContext db;

        public DepartmentsController(TechGuideDbContext context)
        {
            db = context;
        }

        // GET: api/Department
        [HttpGet]
        [ProducesResponseType(typeof(Department[]), 200)]
        public async Task<ActionResult<Department[]>> GetDepartment()
        {
            var data = await db.Departments.Include(t=>t.Subjects).ThenInclude(c=>c.Chapters).ToListAsync();
            return Ok(data);
        }

        // GET: api/Department/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartment(int id)
        {
            var techDepartment = await db.Departments.Include(t=>t.Subjects).ThenInclude(c=>c.Chapters).FirstOrDefaultAsync();
            if (techDepartment == null) return NotFound();
            return Ok(techDepartment);
        }

        // POST: api/Department
        [HttpPost]
        public async Task<IActionResult> CreateDepartment(Department department)
        {
            var existingSubjects = await db.Subjects.FindAsync(department.SubCode);
            if (existingSubjects == null)
            {
                return BadRequest("Invalid SubCode. The specified Subject does not exist.");
            }
            department.Subjects = null;
            db.Departments.Add(department);
            await db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetDepartment), new { id = department.DepID}, department);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDepartment(int id, [FromBody] Department updateddepartment)
        {
            if (id != updateddepartment.DepID)
                return BadRequest("Department ID mismatch.");

            var existingdepartment = await db.Departments.FindAsync(id);
            if (existingdepartment == null)
                return NotFound("Department not found.");
            existingdepartment.DepName = updateddepartment.DepName;
            

            try
            {
                await db.SaveChangesAsync();
                var UpDEP = await db.Departments.Include(t => t.Subjects).ThenInclude(c=>c.Chapters).FirstOrDefaultAsync(t => t.DepID == id);
                return Ok(UpDEP);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!await DepartmentExists(id))
                //    return NotFound("Department not found during update.");
                //throw;
            }
            await db.SaveChangesAsync();
            return NoContent();
        }

        private async Task<bool> DepartmentExists(int id)
        {
            return await db.Departments.AnyAsync(m => m.DepID == id);
        }

        // DELETE: api/Department/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var department = await db.Departments.FindAsync(id);
            if (department == null) return NotFound();
            db.Departments.Remove(department);
            await db.SaveChangesAsync();
            return NoContent();
        }
    }
}
