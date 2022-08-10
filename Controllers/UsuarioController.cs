using Microsoft.AspNetCore.Mvc;

namespace usuario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Ok";
        }
    }
}