using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com.Models
{
    public class tbl_Products
    {
        public int Id { get; set; }
        public string pCode { get; set; }
        public string Slug { get; set; }
        public string ProductName { get; set; }
        public string UserId { get; set; }
        public string OwnerId { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public decimal SalesAmt { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public string pDetails { get; set; }
        public string d_lenght { get; set; }
        public string d_width { get; set; }
        public string d_height { get; set; }
        public decimal Discount { get; set; }
        public decimal PurAmt { get; set; }
        public bool Status { get; set; }
        public bool isCommarce { get; set; }
        public bool isFeature { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public string ThumbImage { get; set; }
    }
}
