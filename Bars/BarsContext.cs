


using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;



namespace Bars
{
    class BarsContext: DbContext
    {
        public DbSet<Bar> Bars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\ProjectTwo2\\Bars\\Cafes.db");
        }

    }
}
