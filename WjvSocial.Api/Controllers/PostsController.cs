using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WjvSocial.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(new {Id= 1, Text="Hola mundo!"});
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            return Ok(new { Id = id, Text = "Hola mundo!" });
        }
    }
}
