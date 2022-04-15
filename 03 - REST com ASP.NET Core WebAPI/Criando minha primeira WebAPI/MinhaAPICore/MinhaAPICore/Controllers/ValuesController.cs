using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> ObterTodos()
        {
            var valores = new string[] { "value1", "value2" };

            if (valores.Length < 5000)
            {
                return BadRequest();
            }

            return Ok(valores);
        }


        [HttpGet]
        public ActionResult ObterResultado()
        {
            var valores = new string[] { "value1", "value2" };

            if (valores.Length < 5000)
            {
                return BadRequest();
            }

            return Ok(valores);
        }


        // GET api/values/5
        [HttpGet("obter-por-id/{id:int }")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }


        // POST api/values
        [HttpPost]
        [ProducesResponseType(typeof(Product), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] Product product)
        {
            return CreatedAtAction("Post", product);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }


    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
