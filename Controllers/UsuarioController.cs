using Microsoft.AspNetCore.Mvc;
using user.Model;

namespace usuario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static List<User> Users()
        {
            return new List<User>
            {
                new User {Id = 1, Name = "Wagner", BirthDate = new DateTime(1995/10/28)}
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Users());
        }

        [HttpPost]
        public IActionResult Post(User user)
        {
            var users = Users();
            users.Add(user);
            return Ok(users);
        }
    }
}