

using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;


namespace AutenticacionCookieControladores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        static List<object> data = new List<object>();

        [HttpGet]


        [AllowAnonymous]
        public IEnumerable<object> Get()
        {
            
            
            return data;
        }



        [AllowAnonymous]
        [HttpPost]
        public  IActionResult Post(string name , string lastname)
        {


            data.Add(new {name, lastname});

            return Ok();
        }




        [Authorize]
        [HttpDelete]
        public IActionResult Delete() 
        {


            data = new List<object>();

            return Ok();
        }
    }
}
