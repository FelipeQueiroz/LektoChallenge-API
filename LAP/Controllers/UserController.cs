using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using LAP.Models;
using LAP.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LAP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return userService.Get();
        }


        [HttpGet("{id}")]
        public ActionResult<User> Get(string id)
        {
            var user = userService.Get(id);

            if(user == null)
            {
                return NotFound($"User with the {id} not found");
            }

            return user;
        }

        [HttpPost("Login")]
        public ActionResult<User> Login(string email, string password)
        {

            var user = userService.Login(email, password);

            if (user == null)
            {
                return BadRequest("Invalid Credentials");
            }

            return user;
        }

        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
            var existingUser = userService.GetByEmail(user.Email);

            if (existingUser != null)
            {
                return BadRequest("This user already exists!");
            }

            userService.Create(user);

            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] User user)
        {
            var existingUser = userService.Get(id);

            if (existingUser == null)
            {
                return NotFound($"User with the {id} not found");
            }

            userService.Update(id, user);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var user = userService.Get(id);

            if (user == null)
            {
                return NotFound($"User with the {id} not found");
            }

            userService.Remove(user.Id);

            return Ok($"User with the {id} was deleted");

        }
    }
}
