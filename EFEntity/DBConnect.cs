using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EFEntity
{
    public class DBConnect:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<tblCustomers> tblCustomers { get; set; }
        public DbSet<tblProducts> tblProducts { get; set; }
        public DbSet<tblCategory> tblCategory { get; set; }
        public DbSet<tblProduct_To_Category> tblProduct_To_Category { get; set; }
        public DbSet<tblRequests> tblRequests { get; set; }
        public DbSet<tblRequestMap> tblRequestMap { get; set; }
        public DbSet<tblOffers> tblOffers { get; set; }
        public DbSet<tblOfferMap> tblOfferMap { get; set; }
        public DbSet<tblEmployees> tblEmployees { get; set; }
        public DbSet<tblOrders> tblOrders { get; set; }
        public DbSet<tblOrderMap> tblOrderMap { get; set; }
    }
}
