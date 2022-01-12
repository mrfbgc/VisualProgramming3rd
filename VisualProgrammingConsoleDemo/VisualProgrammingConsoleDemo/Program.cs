using System;
using System.Collections.Generic;
using System.Linq;

namespace VisualProgrammingConsoleDemo
{
    class Program
    {

        //public static int topla(int x, int y) => x + y;
        //{
          //  return x + y; 

       // } 
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Func<int,int,int> topla = (x, y) => x + y;
            // if a function doesnt return something and also contains more statement, we can use Action<> instead of Func<> but action can not take 3 int


            //Action<int,int> topla = (x, y) => { int z = x + y; Console.WriteLine(z); };
            //topla(5, 4);

            //Func<int, int, int> topla = (x, y) => x + y;
            Func<int, int> square = x => x * x;

            List<int> tamsayilistesi = new List<int>() { 1, 3, 6, 75, 123, 63, 78, 12, 856, 444, 96 };

            // Thanks to Select, we can apply func. into all of the elements

            var result = tamsayilistesi.Select(square);
            foreach(var eleman in result)
            {
                Console.WriteLine(eleman + " "); 
            }

            Console.WriteLine(tamsayilistesi.Min());
            Console.WriteLine(tamsayilistesi.Max());
            Console.WriteLine(tamsayilistesi.Average());

     
        }
    }
}
