using System.Data;
using System.Data.Entity;
using AutoLotDal_NetStandart.Models;

namespace AutoLotDal_NetStandart.EF
{
    public class AutoLotEntities : DbContext
    {
        public AutoLotEntities()
            : base("name=AutoLotConnection")
        {}
        
        public  virtual DbSet<CreditRisk> CreditRisks { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>()
                .HasMany(e=>e.Orders)
                .WithRequired(e=>e.Inventory)
                .WillCascadeOnDelete(false);
        }
        
        
    }
}