using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace APIGUI {
    internal class Cosmic : DbContext {

        public DbSet<ImageData> CosmicImages { get; set; }
        public Cosmic() {
            Database.EnsureCreated();
        }

        

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlite(@"Data Source=Cosm.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        }

    }
}
