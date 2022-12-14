using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Segregare.Models;

namespace Segregare.Contexts
{
    public class Context : DbContext
    {
        public DbSet<Clasa> Clase { get; set; }
        public DbSet<Intrebare> Intrebari { get; set; }
        public DbSet<ScoalaIntrebare> ScoalaIntrebari { get; set; }
        public DbSet<Monitor> Monitori { get; set; }
        public DbSet<MonitorIntrebare> MonitorIntrebari { get; set; }
        public DbSet<Scoala> Scoli { get; set; }
        public DbSet<Unitate> Unitati { get; set; }
        public DbSet<UnitateIntrebare> UnitateIntrebari { get; set; }

        public static bool isMigration = true;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (isMigration)
                optionsBuilder.UseSqlServer(@"Secret1");
        }
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
