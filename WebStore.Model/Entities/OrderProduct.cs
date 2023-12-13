using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Model.Entities
{
    public class OrderProduct
    {
        #region 
        [Key]
        public int Id { get; set; }
        public int? ProductId { get; set;}
        public virtual Product? Product { get; set; }
        public int? OrderId { get;set; }
        public virtual Order? Order { get; set; }
        public int? Quantity {get;set;}
        #endregion
    }
}