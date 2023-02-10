using GreetingsAPI.Schemas;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetingsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        // GET: api/<GreetingsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<GreetingsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GreetingsController>
        [HttpPost]        

        public GreetingsAPI.Schemas.GreetingsResponse Post(GreetingsRequest msggreetingsrequest)
        {
            GreetingsResponse msggreetingsresponse = new GreetingsResponse();
            msggreetingsresponse.Greetings = "Hello " + msggreetingsrequest.Name;

            return msggreetingsresponse;
        }

        // PUT api/<GreetingsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GreetingsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
