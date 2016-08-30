using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            double length, width, area, peri;
            string con;
            
         do
    {

                Console.Write("Enter Length  = ");

                length = double.Parse(Console.ReadLine());

                Console.Write("Enter Width = ");
                width = double.Parse(Console.ReadLine());
           
                Console.Write("Area = ");
                area = length * width;
            //Console.Write(area);
            Console.WriteLine(area);
            Console.Write("Perimeter = ");
            peri = 2*(length + width);
         //   Console.Write(peri);
              Console.WriteLine(peri);
                Console.WriteLine("Continue : ");
                con = Console.ReadLine();
}
           while (con == "Y");
           

        }
    }
}
