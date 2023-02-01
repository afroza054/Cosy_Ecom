using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com.Models
{
    public class tbl_Routes
    {
        public int Id { get; set; }
        public string RouteName { get; set; }
        public string BaseUrl { get; set; }
        public string ApiUser { get; set; }
        public string LoginUser { get; set; }
        public string ApiPassword { get; set; }
        public string LoginPassword { get; set; }
        public string ApiMobile { get; set; }
        public string ApiMessage { get; set; }
        public int Status { get; set; }
        public string RouteType { get; set; }
        public int RouteCode { get; set; }
        public decimal RouteBalance { get; set; }
        public decimal pSmsCost { get; set; }
    }
}
