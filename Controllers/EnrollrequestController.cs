using Institute_Management.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Institute_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollrequestController : ControllerBase
    {
        private readonly InstituteContext _context;

        // Constructor to inject InstituteContext
        public EnrollrequestController(InstituteContext context)
        {
            _context = context;
        }

        // POST: api/enrollrequest
        [HttpPost]
        public async Task<IActionResult> SubmitEnrollRequest([FromBody] EnrollrequestModule enrollRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Return bad request if model state is invalid
            }

            // Add the enroll request to the context
            _context.Enrollrequest.Add(enrollRequest);

            try
            {
                await _context.SaveChangesAsync(); // Save changes to the database
                return Ok(new { message = "Enroll request submitted successfully!" }); // Return success message
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the save operation
                return StatusCode(500, new { message = "An error occurred while submitting the enroll request.", details = ex.Message });
            }
        }


        // GET: api/enrollrequest
        // GET: api/enrollrequest
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EnrollrequestModule>>> GetEnrollRequests()
        {
            // Fetch all enroll requests from the database
            var enrollRequests = await _context.Enrollrequest.ToListAsync();
            if (enrollRequests == null || enrollRequests.Count == 0)
            {
                return NotFound(new { message = "No enroll requests found" });
            }
            return Ok(enrollRequests); // Return list of enroll requests
        }
    }
}
