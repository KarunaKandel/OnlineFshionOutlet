using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineFashionOutletUsingMVC.Models;

namespace OnlineFashionOutletUsingMVC.Data
{
    public class OnlineFashionOutletUsingMVCContext : DbContext
    {
        public OnlineFashionOutletUsingMVCContext (DbContextOptions<OnlineFashionOutletUsingMVCContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineFashionOutletUsingMVC.Models.User> User { get; set; } = default!;
        public DbSet<OnlineFashionOutletUsingMVC.Models.Order> Order { get; set; } = default!;
        public DbSet<OnlineFashionOutletUsingMVC.Models.Product> Product { get; set; } = default!;
    }
}
