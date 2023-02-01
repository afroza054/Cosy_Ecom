using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com.Models
{
    public class tbl_Orders
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public string CustId { get; set; }
        public string OwnerId { get; set; }
        public int payMethod { get; set; }
        public decimal SubTotal { get; set; }
        public decimal DeliCharge { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal DueAmount { get; set; }
        public decimal Discount { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime tDate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime trnDate { get; set; }
        public string OrderStatus { get; set; }
        public bool isCancel { get; set; }
    }
}
