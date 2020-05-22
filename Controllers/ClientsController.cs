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
    public class ClientsController : ControllerBase
    {
        private static readonly int[] ids = new[]
        {
            1, 2, 3, 4, 5
        };
        private static readonly string[] names = new[]
        {
            "Juan Diego", "Alejandro", "David", "Louis", "Fernanda"
        };
        private static readonly string[] emails = new[]
        {
            "juandi@gmail.com", "alerazu23@gmail.com", "kugleblitz@gmail.com", "luislopez@gmail.com", "fershi@gmail.com"
        };
        private static readonly int[] lockers = new[]
        {
            21, 22, 23, 24, 25
        };
        private static readonly int[] phones = new[]
        {
            23023951, 23023952, 23023953, 23023954, 23023955
        };
        private static readonly int[] cellphones = new[]
        {
            83023951, 83023952, 83023953, 83023954, 83023955
        };
        private static readonly string[] users = new[]
        {
            "Juandi Dios", "Droid", "Kruger", "Zucc", "Fernanda"
        };
        private static readonly string[] passwords = new[]
        {
            "Juandi Dios", "Droid", "Kruger", "Zucc", "Fernanda"
        };
        private static readonly string[] provinces = new[]
        {
            "San José", "San José", "Cartago", "Alajuela", "Limón"
        };
        private static readonly string[] states = new[]
        {
            "Escazú", "Puriscal", "Cartago", "Alajuela", "Sixaola"
        };
        private static readonly string[] districts = new[]
        {
            "Santa Ana", "Puriscal", "Cartaguito", "Alajuela", "Sixaola"
        };
        // GET: api/<ClientsController>
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return Enumerable.Range(0, ids.Length - 1).Select(index => new Client
            {
                id = ids[index],
                name = names[index],
                email = emails[index],
                locker = lockers[index],
                phone = phones[index],
                cellphone = cellphones[index],
                user = users[index],
                password = passwords[index],
                province = provinces[index],
                state = states[index],
                district = districts[index]
            })
            .ToArray();
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public IEnumerable<Client> Get(int id)
        {
            var i = id - 1;
            return Enumerable.Range(i, i).Select(index => new Client
            {
                id = ids[index],
                name = names[index],
                email = emails[index],
                locker = lockers[index],
                phone = phones[index],
                cellphone = cellphones[index],
                user = users[index],
                password = passwords[index],
                province = provinces[index],
                state = states[index],
                district = districts[index]
            })
            .ToArray();
        }

        // POST api/<ClientsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
