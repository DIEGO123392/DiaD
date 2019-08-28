using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using luna.Models;

namespace luna.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ValuesController : ControllerBase
    {
        private ProductContext Context;
        public ValuesController (ProductContext DbContext)
        {
        Context = DbContext;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return Context.Product.ToList();
            }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return Context.Product.Find(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            Context.Product.Add(value);
            Context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
          var Produc = Context.Product.Find(); 
          if (Produc != null)
          {
          Produc.Precio= value.Precio;
          Produc.Title = value.Title;
          Produc.Categoria = value.Categoria;
          Produc.Descripcion = value.Descripcion;
          Context.SaveChanges();
          }

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var Produc = Context.Product.Find(id);
            if (Produc != null)
            {
            Context.Product.Remove(Produc);
            Context.SaveChanges();
            }
        }
        
    }
}
