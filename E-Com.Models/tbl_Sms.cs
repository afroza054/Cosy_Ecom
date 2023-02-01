using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com.Models
{
    public class tbl_Sms
    {
        public int Id { get; set; }
        public int TotalSms { get; set; }
        public decimal PerSmsCost { get; set; }
        public string OwnerId { get; set; }
    }
}
