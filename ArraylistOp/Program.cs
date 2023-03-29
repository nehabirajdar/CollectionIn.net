using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArraylistOp.Program;

namespace ArraylistOp
{
    internal class Program
    {
        public class Student
        {
            public int Rollno { get; set; }
            public string Name { get; set; }
            public int Percentage { get; set; }
        }

        static void Main(string[] args)
        {

            ArrayList Students = new ArrayList();
            Students.Add(new Student { Rollno = 10, Name = "Pratik", Percentage = 89 });
            Students.Add(new Student { Rollno = 22, Name = "Viresh", Percentage = 31 });
            Students.Add(new Student { Rollno = 31, Name = "Ganesh", Percentage = 76 });
            Students.Add(new Student { Rollno = 21, Name = "Shraddha", Percentage = 29 });
            Students.Add(new Student { Rollno = 35, Name = "Pooja", Percentage = 86 });


         
            foreach (Student item in Students)
            {
                Console.WriteLine($"{item.Rollno}- {item.Name} - {item.Percentage}");
                
            }
            Console.WriteLine("--------------------");
            foreach (Student item in Students)
            {
                if (item.Percentage >35)
                {
                    Console.WriteLine($"{item.Rollno}- {item.Name} - {item.Percentage}");
                }

            }
            List<string>product= new List<string>();
            product.Add("Laptop");
            product.Add("iphone");

            List<double>price= new List<double>();
            price.Add(67000);
            price.Add(56700);
        }
       
            


    }
}

