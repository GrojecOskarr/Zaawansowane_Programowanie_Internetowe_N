using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.Entities
{
    public class Customer : User
    {
        #region properties
        public virtual IList<Address> Addresses { get;set; } = new List<Address>();
        public virtual IList<Order> Orders {get;set;} = new List<Order>();
        #endregion
    }
}