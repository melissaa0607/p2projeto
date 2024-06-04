using Microsoft.EntityFrameworkCore;
using RoletaAPI.Models;
using System.Collections.Generic;

namespace RoletaAPI.Data
{
    public class RoletaContext : DbContext
    {
        public RoletaContext(DbContextOptions<RoletaContext> options) : base(options) { }

        public DbSet<Premio> Premios { get; set; }
        public DbSet<Cupom> Cupons { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}