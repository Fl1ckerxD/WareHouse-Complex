//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Warehouse_Complex
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WareHouseEntities : DbContext
    {
        public WareHouseEntities()
            : base("name=WareHouseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Expens> Expens { get; set; }
        public virtual DbSet<Good> Good { get; set; }
        public virtual DbSet<ProductLocation> ProductLocation { get; set; }
        public virtual DbSet<Recipient> Recipient { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<Supply> Supply { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeUser> TypeUser { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }
    }
}
