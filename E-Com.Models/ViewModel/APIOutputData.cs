using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com.Models.ViewModel
{
    public class APIOutputData
    {
        public int success { get; set; }
        public string message { get; set; }
        public string msgid { get; set; }
        public int jobid { get; set; }
        public string msisdn { get; set; }
        public string ActuialStatus { get; set; }
    }
}
