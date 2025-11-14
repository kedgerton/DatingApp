using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    // [Route("api/[controller]")] // https://localhost:5001/api/members
    // [ApiController]
    // AppDbContext context will create a DB session from the Program.cs builder
    // This is because AppDbContext is registered
    public class MembersController(AppDbContext context) : BaseApiController
    {
        [HttpGet] // https://localhost:5001/api/members
        // ActionResult will return a http response like 200 or 404 ect
        // ActionResult List is what is the type of data the will be returned
        // Appuser will be what is returned
        // GetMemmbers is a made up name made to be a script block
        // ActionResult IReadOnlyList is a read only result
        // async allows multiple request ( Multithreading ) to run ( without it all request have to be returned before a new one can be made )
        // Task is basically the thread that was created
        public async Task<ActionResult<IReadOnlyList<AppUser>>> GetMembers()
        {
            // Create a variable name members. Get the context from the table Users and data returned is a list
            // await will waite for the return response.
            // ToList Async method is used.
            var members = await context.Users.ToListAsync();

            return members;
        }
        [Authorize]
        [HttpGet("{id}")] // https://localhost:5001/api/members/bob-id
        public async Task<ActionResult<AppUser>> GetMember(string id)
        {
            var member = await context.Users.FindAsync(id);

            if (member == null) return NotFound();

            return member;
        }
    }
}
