using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Govimithuro.Models;

namespace Govimithuro.Models
{
    public class GovimithuroDbContext : DbContext
    {
        public GovimithuroDbContext(DbContextOptions<GovimithuroDbContext> options)
            : base(options)
        {
        }
        public DbSet<Govimithuro.Models.Admin> AdminTable { get; set; }
        public DbSet<Govimithuro.Models.Customer> CustomerTable { get; set; }

        public DbSet<Govimithuro.Models.Farmer> FarmerTable { get; set; }
        public DbSet<Govimithuro.Models.Order> OrderTable { get; set; }
        public DbSet<Govimithuro.Models.OrderDetails> OrderDetailsTable { get; set; }
        public DbSet<Govimithuro.Models.Product> ProductTable { get; set; }
        public DbSet<Govimithuro.Models.Cart> CartTable { get; set; }
        public DbSet<Govimithuro.Models.Category> CategoryTable { get; set; }
        public DbSet<Govimithuro.Models.BillingInfo> BillingInfoTable { get; set; }

    }



}
