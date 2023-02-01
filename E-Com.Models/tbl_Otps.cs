using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com.Models
{
    public class tbl_Otps
    {
        public int Id { get; set; }
        public string MobileNumber { get; set; }
        public string OwnerId { get; set; }
        public int OTP_Code { get; set; }
        public DateTime trnDate { get; set; }
        public string Reason { get; set; }
    }
}
