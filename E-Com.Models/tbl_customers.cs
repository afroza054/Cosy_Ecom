using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com.Models
{
    public class tbl_customers
    {
        public int Id { get; set; }
        public string CustId { get; set; }
        public string CustName { get; set; }
        public string CustMobile { get; set; }
        public string OtherMobile { get; set; }
        public string CusAaddress { get; set; }
        public string CustEmail { get; set; }
        public string UserId { get; set; }
        public string OwnerId { get; set; }
        public string DeliveryAaddress { get; set; }
        public int DistrictId { get; set; }
    }
}
