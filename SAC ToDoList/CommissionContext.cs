using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAC_ToDoList
{
    public class CommissionContext : DbContext
    {
        public DbSet<Commission> Commissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ericchi.moe;Database=Sessione2_SPA;User Id=SA;Password=DatabaseCaconeDegenerato;TrustServerCertificate=True");
        }
    }
}
