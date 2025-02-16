using Institute_Management.DTOs;
using Institute_Management.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Institute_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewTeacherController : Controller
    {
        private readonly InstituteContext _context;

        public NewTeacherController(InstituteContext context)
        {
            _context = context;
        }

        // POST: api/NewTeacher
        [HttpPost]
        public async Task<IActionResult> CreateTeacher([FromBody] NewteacherDTO newTeacherDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Map DTO to Model
            var newTeacher = new Newteacher
            {
                Name = newTeacherDto.Name ?? string.Empty,
                Email = newTeacherDto.Email ?? string.Empty,
                Password = newTeacherDto.Password ?? string.Empty,
                Role = newTeacherDto.Role ?? string.Empty,
                ContactDetails = newTeacherDto.ContactDetails ?? string.Empty,
                SubjectSpecialization = newTeacherDto.SubjectSpecialization ?? string.Empty
            };

            _context.Newteachers.Add(newTeacher);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Teacher data saved successfully!" });
        }

        // GET: api/newTeacher
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewteacherDTO>>> GetTeachers()
        {
            var teachers = await _context.Newteachers
                .Select(t => new NewteacherDTO
                {
                    Id = t.Id,
                    Name = t.Name,
                    Email = t.Email,
                    Password = t.Password,
                    Role = t.Role,
                    ContactDetails = t.ContactDetails,
                    SubjectSpecialization = t.SubjectSpecialization
                })
                .ToListAsync();

            return Ok(teachers);
        }
    }
}
