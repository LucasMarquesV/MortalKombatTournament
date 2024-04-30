using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Config
{
    public class ContextoBase : DbContext
    {

        public ContextoBase(DbContextOptions<ContextoBase> options) : base(options) { }

        public DbSet<LutadorModel> Lutadores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = CTS1A519661\\SQLEXPRESS; Database = DB_Lutadores; Integrated Security = True; TrustServerCertificate = True");
            }
        }
    }
}
