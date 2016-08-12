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
            string strNum = "";
            decimal num = 0;
            while (decimal.TryParse(strNum, out num) != true)
            {
                Console.Write("Enter a Number That I Can Multiply By 10: ");
                strNum = Console.ReadLine();
            };
            num = Convert.ToDecimal(strNum) * 10;
            Console.WriteLine(strNum + " Times 10 = " + Convert.ToString(num));
            Console.ReadLine();
        }
    }
}
