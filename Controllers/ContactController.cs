using Institute_Management.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Institute_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController(InstituteContext context) : Controller
    {
        private readonly InstituteContext _context = context;

        [HttpPost]
        public async Task<IActionResult> SubmitContact([FromBody] ContactUs contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Contactus.Add(contact);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Contact form submitted successfully!" });
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactUs>>> GetContacts()
        {
            return await _context.Contactus.ToListAsync();
        }
    }
}
