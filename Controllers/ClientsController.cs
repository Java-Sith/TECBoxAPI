﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TECBoxAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECBoxAPI.Controllers
{
    [Route("[controller]")]
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
        private static readonly string[] others = new[]
        {
            "Mi casa", "Lejos de aquí", "No sé", "fuiableuif", "Costa Rica"
        };
        // GET: api/<ClientsController>
        [HttpGet]
        public IActionResult Get()
        {
            Client[] response = new Client[5];

            for (int i = 0; i < response.Length; i++)
            {
                response[i] = new Client
                {
                    cedula = ids[i],
                    nombre = names[i],
                    correo = emails[i],
                    casillero = lockers[i],
                    celular = cellphones[i],
                    habitacion = phones[i],
                    usuario = users[i],
                    pass = passwords[i],
                    provincia = provinces[i],
                    canton = states[i],
                    distrito = districts[i],
                    otras = others[i]
                };
            }


            return Ok(new { result = 200, items = response });
        }

        // POST api/<ClientsController>
        [HttpPost]
        public IActionResult Post([FromBody] Client client)
        {
            return Ok(new { result = "Worker " + client.cedula + " added." });
        }

        // PUT api/<ClientsController>/5
        [HttpPut]
        public IActionResult Put([FromBody] UpdateClient value)
        {
            return Ok(new { result = "Client with id " + value.cedula_old + " was updated with the client with id " + value.cedula_new });
        }

        // DELETE api/<ClientsController>/5
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(new { result = "Client with id " + id + " deleted." });
        }
    }
}
