using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcAuth.Models;

namespace MvcAuth.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Products{get;set;}
        public DbSet<Stock> Inventory{get;set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
