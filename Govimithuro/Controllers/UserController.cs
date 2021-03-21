using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Govimithuro.Models;

namespace Govimithuro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly GovimithuroDbContext _context;

        public UserController(GovimithuroDbContext context)
        {
            _context = context;
        }

        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUserTable()
        {
            return await _context.UserTable.ToListAsync();
        }

        // GET: api/User/5
        [HttpGet("{email}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.UserTable.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        //// PUT: api/user/email
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{email}")]
        //public async Task<IActionResult> PutFarmer(string email, User user)
        //{
        //    if (email != user.Email)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(email).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UserExists(email))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Farmer
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.


        // DELETE: api/User/email

        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(string id)
        {
            var user = await _context.UserTable.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.UserTable.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private bool UserExists(string email)
        {
            return _context.UserTable.Any(e => e.Email == email);
        }
    }
}
