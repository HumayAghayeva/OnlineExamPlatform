using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using API.Interfaces;
using API.Models;
using API.Services;
using Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineExamAPI.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _user;
        public UserController(IUserService user)
        {
            this._user = user;
        }

        // GET: api/<UserController>
        [HttpGet]
        public List<User> Get()
        {
            var usr = _user.GetUsers();
            return usr;
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            var usr = _user.GetUser(id);
            return usr;
        }
        [EnableCors("AllowOrigin")]
        [HttpGet("{email}/{password}")]
        public User Get(string email, string password)
        {
            var usr = _user.Login(email, password);
            return usr;
        }

        [HttpPost]
        public User Post(User user)
        {
            _user.AddUser(user);
            return user;    
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
