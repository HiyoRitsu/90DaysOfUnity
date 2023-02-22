using System;
using System.Xml.Linq;

namespace TheThirdOne
{
    class Third
    {

        /*      static void singSong()
              {
                  Console.WriteLine("One");
                  Console.WriteLine("Two");
                  Console.WriteLine("Three");
              }
              static void Main(string[] args)
              {
                  singSong();
              }
        */


        /*       static void MyMethod(string fname)
               {
                   Console.WriteLine(fname + " Refsnes");
               }

               static void Main(string[] args)
               {
                   MyMethod("Liam");
                   MyMethod("Jenny");
                   MyMethod("Anja");
               }

               // Liam Refsnes
               // Jenny Refsnes
               // Anja Refsnes

       */


        /*       static int MyMethod(int x, int y)
               {
                   return x + y;
               }

               static void Main(string[] args)
               {
                   Console.WriteLine(MyMethod(5, 3));
               }

               // Outputs 8 (5 + 3)



               static void MyMethod(string child1, string child2, string child3)
               {
                   Console.WriteLine("The youngest child is: " + child3);
               }

               static void Main(string[] args)
               {
                   MyMethod(child3: "John", child1: "Liam", child2: "Liam");
               }

               // The youngest child is: John
        */


        /*       With method overloading, multiple methods can have the same name with different parameters:
                   static int PlusMethod(int x, int y)
               {
                   return x + y;
               }

               static double PlusMethod(double x, double y)
               {
                   return x + y;
               }

               static void Main(string[] args)
               {
                   int myNum1 = PlusMethod(8, 5);
                   double myNum2 = PlusMethod(4.3, 6.26);
                   Console.WriteLine("Int: " + myNum1);
                   Console.WriteLine("Double: " + myNum2);
               }

               */
        static void Main(string[] args)
        {
            double total = CheckOut(1.1, 1.2);
            Console.WriteLine(total);
        }
       
        static double CheckOut(params double[] prices)
        {
            double total = 0;
            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }
    }
   
}