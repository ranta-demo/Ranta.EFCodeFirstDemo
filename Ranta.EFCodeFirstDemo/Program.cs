using Ranta.EFCodeFirstDemo.Repository;
using Ranta.EFCodeFirstDemo.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.EFCodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var demoDB = new RantaDemoDBContext())
            {
                var name = Console.ReadLine();

                var student = new Student { Name = name };
                demoDB.Students.Add(student);
                demoDB.SaveChanges();

                var query = from b in demoDB.Students orderby b.Name select b;

                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.Read();
            }
        }
    }
}
