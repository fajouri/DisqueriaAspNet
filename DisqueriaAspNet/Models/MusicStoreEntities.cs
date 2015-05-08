using DisqueriaAspNet.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DisqueriaAspNet.Models
{
  
    public class MusicStoreEntities: DbContext
    {
         static MusicStoreEntities()
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MusicStoreEntities>());
            Database.SetInitializer<MusicStoreEntities>(null);
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CartMapping());

            base.OnModelCreating(modelBuilder);

        }
    }
}