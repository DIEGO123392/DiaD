using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using luna.Models;

namespace ClienteController
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ClienteController : ControllerBase
    {
        private ProductContext Context;
        public ClienteController (ProductContext DbContext)
        {
        Context = DbContext;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            return Context.Cliente.ToList();
            }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(int id)
        {
            return Context.Cliente.Find(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Cliente value)
        {
            Context.Cliente.Add(value);
            Context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente value)
        {
          var Client = Context.Cliente.Find(); 
          if (Client != null)
          {
          Client.Nombre= value.Nombre;
          Client.apellido = value.apellido;
          Client.UserName = value.UserName;
          Client.Email = value.Email;
          Context.SaveChanges();
          }

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var Client = Context.Cliente.Find(id);
            if (Client != null)
            {
            Context.Cliente.Remove(Client);
            Context.SaveChanges();
            }
        }
    
    }
}