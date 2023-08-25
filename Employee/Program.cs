using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {


        public int age { get; set; }
        public double sal { get; set; }
        public String name { get; set; }


        public Program( string name,int age,double sal)
        {
            name = name;
            age = age;
            sal = sal;
        }
        public void Display()

        {
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Age:{age}");
            Console.WriteLine($"SAl:{sal}");

        }




    }
    class P
    {
        static void Main(string[] args)
        {
            Program obj = new Program("john doe", 45, 5000);
            obj.Display();
        }
    }

}

