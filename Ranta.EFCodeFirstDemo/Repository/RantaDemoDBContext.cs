using Ranta.EFCodeFirstDemo.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.EFCodeFirstDemo.Repository
{
    public class RantaDemoDBContext : DbContext
    {
        public RantaDemoDBContext() : base("RantaDemoDB")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
