using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTStorage.Options
{
    class OptionsContext: DbContext
    {
        public OptionsContext() : base("OptionsDB")
        { }

        public DbSet<Option> optionsDB { get; set; }
    }
}
