using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com.Models
{
    public class tbl_Order_Trn_Details
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public string pCode { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public decimal dAmount { get; set; }
        public decimal GrandTotal { get; set; }
        public string OwnerId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime trnDate { get; set; }
        public bool isCancel { get; set; }
    }
}
