using Microsoft.AspNetCore.Mvc;
using user.Model;

namespace user.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static List<User> Users => new List<User>
            {
                new User {Id = 1, Name = "Wagner", BirthDate = new DateTime(1995/10/28)}
            };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var SelectUser = Users.FirstOrDefault(x => x.Id == id);

            return SelectUser != null
                ? Ok(Users)
                : BadRequest("Error to finding User");
        }

        [HttpPost]
        public IActionResult Post(User user)
        {
            var users = Users;
            users.Add(user);
            return Ok(users);
        }
    }
}