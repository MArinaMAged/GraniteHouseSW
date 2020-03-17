using System;
using System.Collections.Generic;
using System.Text;
using GraniteHouseSW.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GraniteHouseSW.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet <ProductTypes> ProductTypes { get; set; }
    }
}
