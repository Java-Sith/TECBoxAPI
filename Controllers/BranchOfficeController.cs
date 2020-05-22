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
    public class BranchOfficeController : ControllerBase
    {
        private static readonly string[] name = new[]
        {
            "Alejandro", "José", "Michelle", "Hércules", "Milton"
        };
        private static readonly string[] province = new[]
        {
            "Alejandro", "José", "Michelle", "Hércules", "Milton"
        };
        private static readonly string[] state = new[]
        {
            "Alejandro", "José", "Michelle", "Hércules", "Milton"
        };
        private static readonly string[] district = new[]
        {
            "Alejandro", "José", "Michelle", "Hércules", "Milton"
        };
        private static readonly int[] phones = new[]
        {
            23023951, 23023952, 23023953, 23023954, 23023955
        };
        // GET: api/<BranchOfficeController>
        [HttpGet]
        public IEnumerable<BranchOffice> Get()
        {
            return Enumerable.Range(0, name.Length - 1).Select(index => new BranchOffice
            {
                name = name[index],
                province = province[index],
                state = state[index],
                district = district[index],
                phone = phones[index]
            })
            .ToArray();
        }

        // GET api/<BranchOfficeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BranchOfficeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BranchOfficeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BranchOfficeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
