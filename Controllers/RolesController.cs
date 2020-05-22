using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TECBoxAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECBoxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private static readonly string[] names = new[]
        {
            "Camilo", "Evaluna", "Jonathan", "Jaime", "Ricardo", "Valentine"
        };
        private static readonly string[] descriptions = new[]
        {
            "Administrador", "Repartidor", "Bodeguero"
        };
        // GET: api/<RolesController>
        [HttpGet]
        public IEnumerable<Role> Get()
        {
            var rng = new Random();
            return Enumerable.Range(0, names.Length - 1).Select(index => new Role
            {
                name = names[index],
                description = descriptions[rng.Next(descriptions.Length)]
            })
            .ToArray();
        }

        // GET api/<RolesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RolesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RolesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RolesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
