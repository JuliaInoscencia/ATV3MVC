using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SisControleVendas.Models;

namespace SisControleVendas.Data
{
    public class SisControleVendasContext : DbContext
    {
        public SisControleVendasContext (DbContextOptions<SisControleVendasContext> options)
            : base(options)
        {
        }

        public DbSet<SisControleVendas.Models.Client> Client { get; set; } = default!;
        public DbSet<SisControleVendas.Models.Credential> Credential { get; set; } = default!;
        public DbSet<SisControleVendas.Models.Employee> Employee { get; set; } = default!;
        public DbSet<SisControleVendas.Models.Product> Product { get; set; } = default!;
        public DbSet<SisControleVendas.Models.Sale> Sale { get; set; } = default!;
        public DbSet<SisControleVendas.Models.UserInfo> UserInfo { get; set; } = default!;
    }
}
