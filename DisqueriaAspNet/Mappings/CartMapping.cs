using DisqueriaAspNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DisqueriaAspNet.Mappings
{
    public class CartMapping : EntityTypeConfiguration<Cart>
    {
        public CartMapping() 
        {
            HasKey(m => m.RecordId);
        }
    }
}