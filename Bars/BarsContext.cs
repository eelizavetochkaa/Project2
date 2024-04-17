using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Bars
{
    internal class BarsContext: DbContext
    {
        public DbSet<Bar> Bars { get; set; }
    }
}
