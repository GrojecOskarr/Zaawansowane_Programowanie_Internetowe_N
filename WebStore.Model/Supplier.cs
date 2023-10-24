using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model
{
    public class Supplier : User
    {
        public virtual IList<Product> Products { get; set; } = new List<Product>();
    }
}