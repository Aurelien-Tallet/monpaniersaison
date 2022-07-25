namespace back.Controllers;
using Microsoft.AspNetCore.Mvc;
using back.Models;
using Microsoft.AspNetCore.JsonPatch;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public EmployeesController(ApplicationDbContext context) 
    {
        _context = context;
    }
    [HttpGet(Name = "GetEmployees")]
    public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
    {
        var employees = await _context.Employees.ToListAsync();
        if (employees == null)
        {
            return NotFound();
        }
        return Ok(employees);
    }

    [HttpGet("{id}", Name = "GetEmployee")]
    public async Task<ActionResult<Employee>> GetEmployee(int id)
    {
        var employee = await _context.Employees.FindAsync(id);
        if (employee == null)
        {
            return NotFound(id);
        }
        return Ok(employee);
    }
    [HttpPost]
    public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
    {
        // Generate auto Increment Id
        employee.Id = 0;
        _context.Employees.Add(employee);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetEmployee", new { id = employee.Id }, employee);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutEmployee(int id, Employee employee)
    {
        if (id != employee.Id)
        {
            return BadRequest();
        }
        _context.Entry(employee).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }
    // Patch with partial update of the employee with JsonPatch 
    [HttpPatch("{id}")]
    public async Task<IActionResult> PatchEmployee(int id,[FromBody]JsonPatchDocument<Employee> patch)
    {
        var employee = await _context.Employees.FindAsync(id);
        if (employee == null)
        {
            return NotFound();
        }
        patch.ApplyTo(employee);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
        var employee = await _context.Employees.FindAsync(id);
        if (employee == null)
        {
            return NotFound(id);
        }
        _context.Employees.Remove(employee);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}