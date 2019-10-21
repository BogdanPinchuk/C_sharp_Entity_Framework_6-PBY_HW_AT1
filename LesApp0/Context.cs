using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    public class MyContext : DbContext
    {
        public MyContext()
            :base("DbConncection") { }

        public DbSet<Model> Models { get; set; }
    }
}
