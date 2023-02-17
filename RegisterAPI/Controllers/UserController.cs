using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RegisterAPI.Interfaces;
using RegisterAPI.Models;
using RegisterAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RegisterAPI.Controllers
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

        //[HttpGet]
        //public User Login(string email, string password)
        //{
        //    var usr = _user.Login(email, password);
        //    return usr;
        //}
        // GET api/<UserController>/5
        [HttpGet("{id}")]
        [EnableCors("AllowOrigin")]
        public User Get(int id)
        {
            var usr = _user.GetUser(id);
            return usr;
        }

        // POST api/<UserController>
        [HttpPost]
        //[Route("AddUser")]
        public void Post(User user)
        {
            _user.AddUser(user);
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
