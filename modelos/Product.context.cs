using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace luna.Models
{
        public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        { }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
    
    }

    public class Product
    {
       
        public int ProductoId { get; set; }
         [Key]
        public int Precio { get; set; }
        public string Title { get; set; }
        public int Categoria { get; set; }
        public int Descripcion { get; set; }
        public List<Product> Posts { get; set;}
    }
    public class Cliente

    {
        [Key]
        public int id { get; set; }
        public string Nombre { get; set; }
        public string apellido { get; set; }
        public int UserName { get; set; }
        public int Email { get; set; }
    }
}
