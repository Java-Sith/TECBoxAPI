using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TECBoxAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECBoxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkersController : ControllerBase
    {
        private static readonly int[] id = new[]
        {
            1, 2, 3, 4, 5
        };
        private static readonly int[] monthSalary = new[]
        {
            160000, 240000, 32000, 40000, 48000
        };
        private static readonly int[] hourSalary = new[]
        {
            160000 / (40 * 4), 240000 / (40 * 4), 32000 / (40 * 4), 40000 / (40 * 4), 48000 / (40 * 4)
        };
        private static readonly string[] firstName = new[]
        {
            "Alejandro", "José", "Michelle", "Hércules", "Milton"
        };
        private static readonly string[] lastName = new[]
        {
            "Fernández", "José", "Scott", "Poirot", "Villegas"
        };
        private static readonly string[] birthdate = new[]
        {
            "12 de junio", "14 de febrero", "5 de enero", "5 de noviembre", "13 de abril"
        };
        private static readonly string[] password = new[]
        {
            "alefer102", "josejoserocker", "pudding", "bestdetectivever", "ceconnection"
        };
        private static readonly string[] firstdate = new[]
        {
            "12 de junio", "14 de febrero", "5 de enero", "5 de noviembre", "13 de abril"
        };
        // GET: api/<WorkersController>
        [HttpGet]
        public IEnumerable<Worker> Get()
        {
            return Enumerable.Range(0, id.Length - 1).Select(index => new Worker
            {
                id = id[index],
                firstName = firstName[index],
                lastName = lastName[index],
                birthdate = birthdate[index],
                firstdate = firstdate[index],
                monthSalary = monthSalary[index],
                hourSalary = hourSalary[index],
                password = password[index]
            })
            .ToArray();
        }

        // GET api/<WorkersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WorkersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WorkersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WorkersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
