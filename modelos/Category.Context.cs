using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace luna.Models
{

    public class Category

    {
        public int Product { get; set;}
        [Key]
        public int id { get; set; }
    }
}