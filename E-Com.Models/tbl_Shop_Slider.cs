using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com.Models
{
    public class tbl_Shop_Slider
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public int BannerType { get; set; } // 1 for Web and 2 for Mobile
        public string OwnerId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime trnDate { get; set; } 
        public bool Status { get; set; } 
    }
}
