using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Govimithuro.Models;

namespace Govimithuro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly GovimithuroDbContext _context;

        //-------------------
        public readonly IConfiguration _config;
        //------------------

        public LoginController(IConfiguration config,GovimithuroDbContext context)
        {
            _context = context;
        }



        // GET: api/Login
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Login>>> GetLoginTable()
        {
            return await _context.LoginTable.ToListAsync();
        }

        // GET: api/Login/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Login>> GetLogin(int id)
        {
            var login = await _context.LoginTable.FindAsync(id);

            if (login == null)
            {
                return NotFound();
            }
            return login;
        }





        // POST: api/Login
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Login>> PostLogin(Login login)
        {
            try
            {            // CustomerModelDB.Add(newcustomer);
                var CheckEmailCustomer = _context.CustomerTable.FirstOrDefault(m => m.Email.ToLower() == login.Email.ToLower()); //check email already exit or not
                var CheckPasswordCustomer = _context.CustomerTable.FirstOrDefault(m => m.Password == login.Password);
                
                //  var CheckEmailFarmer = _context.FarmerTable.FirstOrDefault(m => m.Email.ToLower() == login.Email.ToLower()); //check email already exit or not
                //var CheckPasswordFarmer = _context.FarmerTable.FirstOrDefault(m => m.Password == login.Password);


                if ((CheckEmailCustomer == null || CheckPasswordCustomer == null) /*&& (CheckEmailSeller == null || CheckPasswordSeller == null)*/)
                {

                    return Ok("NOT VALID"); //New page
                }

                else
                {
                    // return Ok(CheckPasswordCustomer);   // sends the data of user
                    return Ok("Welcome");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            /*
             _context.LoginTable.Add(login);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLogin", new { id = login.LoginId }, login);
        }
*/

        }
    }

}
    
            
            
            
 
