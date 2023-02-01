using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com.Models.ViewModel
{
    public class OrderItemDetails
    {
        public int Id { get; set; }  
        public int productId { get; set; }  
        public string OrderId { get; set; }  
        public string pCode { get; set; }  
        public string ProductName { get; set; }  
        public string ThumbImage { get; set; }  
        public decimal Amount { get; set; }  
        public decimal GrandTotal { get; set; }  
        public int Quantity { get; set; }  
        public string DeliveryAaddress { get; set; }
        //Jabin
        public string OwnerId { get; set; }
        public DateTime trnDate { get; set; }
    }
}
