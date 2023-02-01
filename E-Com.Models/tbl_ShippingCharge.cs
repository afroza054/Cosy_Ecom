using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com.Models
{
    public class tbl_ShippingCharge
    {
        public int Id { get; set; }
        public decimal ShippingChargeInDhaka { get; set; }
        public decimal ShippingChargeOutDhaka { get; set; }
        public string OwnerId { get; set; }
    }
}
