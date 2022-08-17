using Microsoft.AspNetCore.Mvc;
using user.Model;
using user.Repository;

namespace user.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        public UserController(IUserRepository repository)
        {
            
        }

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