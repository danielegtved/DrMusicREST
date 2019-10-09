using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrMusicREST.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrMusicREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        public static readonly List<Record> records = new List<Record>
        {
            new Record("Hej", "Knud", new TimeSpan(0,3,16), new DateTime(2001, 2, 1)),
            new Record("Hallo", "Bent", new TimeSpan(0,4,41), new DateTime(2002, 3, 1)),
            new Record("Lucas Hjælp", "Morten", new TimeSpan(0,1,20), new DateTime(2004, 4, 1)),
            new Record("Fuck dig Morten", "Lucas", new TimeSpan(0,5,40), new DateTime(2004, 1, 1))
        };
        // GET: api/Records
        [HttpGet]
        public IEnumerable<Record> Get()
        {
            return records;
        }

        // GET: api/Records/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Records
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Records/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
