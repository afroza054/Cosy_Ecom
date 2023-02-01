using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com.Models
{
    public class tbl_Shop_Settings
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public string MobileNumber { get; set; }
        public string CustomerCareNumber { get; set; }
        public string EmailId { get; set; }
        public string ShopAddress { get; set; }
        public string ShopLogo { get; set; }
        public string OwnerId { get; set; }
    }
}
