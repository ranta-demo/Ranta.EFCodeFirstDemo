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
        /// <summary>
        /// 测试一：放Name
        /// </summary>
        //public RantaDemoDBContext() : base("RantaDemoDB")
        //{
        //}

        /// <summary>
        /// 测试二：放ConnString
        /// </summary>
        public RantaDemoDBContext() : base(@"Data Source=BLUEWIND\BLUESERVER;Initial Catalog=RantaDemoDB;Integrated Security=True")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
