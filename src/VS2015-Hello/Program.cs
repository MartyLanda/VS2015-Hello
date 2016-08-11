using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VS2015_Hello
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ". It's nice to meet you!");
            Console.ReadLine();
        }
    }
}
