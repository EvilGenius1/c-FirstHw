using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void result()
        {
            int a, b;
            int result;

            Console.WriteLine("Enter a , b : ");
          a = Convert.ToInt32(Console.ReadLine());
          b = Convert.ToInt32(Console.ReadLine());

            result = a / b;

        }
        static void Main(string[] args)
        {
            Program a = new Program();
            int ggg;
            a.result();
        }
    }
}
