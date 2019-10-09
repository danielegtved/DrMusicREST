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
            new Record("Hej", "Knud", new TimeSpan(0,3,16), new DateTime(2001, 2, 1), 1),
            new Record("Hallo", "Bent", new TimeSpan(0,4,41), new DateTime(2002, 3, 1), 2),
            new Record("Lucas Hjælp", "Morten", new TimeSpan(0,1,20), new DateTime(2004, 4, 1), 3),
            new Record("Fuck dig Morten", "Lucas", new TimeSpan(0,5,40), new DateTime(2004, 1, 1), 4)
        };
        // GET: api/Records
        [HttpGet]
        public IEnumerable<Record> Get()
        {
            return records;
        }

        // GET: api/Records/5
        [HttpGet]
        [Route("{id}")]
        public Record Get(int id)
        {
            return records.FirstOrDefault(record => record.Id == id);
        }

        // POST: api/Records
        [HttpPost]
        public void Post([FromBody] Record record)
        {
            records.Add(record);
        }

        // PUT: api/Records/5
        [HttpPut]
        [Route("{id}")]
        public void Put(int id, [FromBody] Record value)
        {
            Record record = Get(id);
            if (record != null)
            {
                record.Id = value.Id;
                record.Title = value.Title;
                record.Artist = value.Artist;
                record.DateOfPublication = value.DateOfPublication;
                record.Duration = value.Duration;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            Record record = Get(id);
            records.Remove(record);
        }
    }
}
