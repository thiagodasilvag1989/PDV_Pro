using Microsoft.EntityFrameworkCore;
using PDV_Pro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDV_Pro.Infra.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
