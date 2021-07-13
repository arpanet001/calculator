using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculator
{
 class Program
 {
  static void Main(string[] args)
  {
   double firstnum;
   double secondnum;
   double answer;
   string ops;

   Console.WriteLine("\t\t\t CONSOLE CALCULATOR TUTORIAL IN C#\n");

   Console.WriteLine("\t\t\t -------------------------------- \n");

   Console.WriteLine("\t\t\t Enter first number : \n");
   firstnum = Double.Parse(Console.ReadLine());

   Console.WriteLine("\t\t\t Select an Operator : (+,-,*,/,%,^) ");
   ops = Console.ReadLine();

   Console.WriteLine("\t\t\t Enter second number : \n");
   secondnum = Double.Parse(Console.ReadLine());

   if (ops == "+")
   {
    answer = firstnum + secondnum;
    Console.Write("\n" + answer);
   }

   if (ops == "-")
   {
    answer = firstnum - secondnum;
    Console.Write("\n" + answer);
   }

   if (ops == "*")
   {
    answer = firstnum + secondnum;
    Console.Write("\n" + answer);
   }

   if (ops == "/")
   {
    answer = firstnum + secondnum;
    Console.Write(answer);
   }

   if (ops == "%")
   {
    answer = firstnum + secondnum;
    Console.Write("\n" + answer);
   }

   if (ops == "^")
   {
    answer = firstnum + secondnum;
    Console.Write("\n" + answer);
   }

   Console.Write("\n\n\t\t\t" + " Press any key to exit....");

   Console.ReadKey();

  }
 }
}
