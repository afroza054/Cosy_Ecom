using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com.Models
{
    public class insideEdgeEcomDbContext : DbContext
    {
        public insideEdgeEcomDbContext() : base("name=insideEdgeEcomDbContext")
        {
        }
        public DbSet<tbl_Products> Products { get; set; }
        public DbSet<tbl_ProductImages> ProductImages { get; set; }
        public DbSet<tbl_Routes> routes { get; set; }
        public DbSet<tbl_Otps> otps { get; set; }
        public DbSet<tbl_customers> customers { get; set; }
        public DbSet<tbl_Districts> Districts { get; set; }
        public DbSet<tbl_ShippingCharge> Shipping { get; set; }
        public DbSet<tbl_Orders> Orders { get; set; }
        public DbSet<tbl_Order_Trn_Details> OrderTrnDetails { get; set; }
        public DbSet<tbl_Shop_Settings> ShopSettings { get; set; }
        public DbSet<tbl_Shop_Slider> ShopSliders { get; set; }
        public DbSet<tbl_Shop_Pages> ShopPages { get; set; }
        public DbSet<tbl_Sms> Sms { get; set; }

        private void FixEfProviderServicesProblem()
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
