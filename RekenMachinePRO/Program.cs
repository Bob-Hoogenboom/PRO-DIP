using System;
using System.Threading;

namespace PROles1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt;
            int secondInt;
            int answer;
            string uitvoering;
            bool answer1 = true;

            Console.Clear();

Console.WriteLine("              _____________________          ");
Console.WriteLine("             |  _________________  |         ");
Console.WriteLine("             | |   REKENEN MET   | |         ");
Console.WriteLine("             | |______GERRIT_____| |         ");
Console.WriteLine("             |  ___ ___ ___   ___  |         ");
Console.WriteLine("             | | 7 | 8 | 9 | | + | |         ");
Console.WriteLine("             | |___|___|___| |___| |         ");
Console.WriteLine("             | | 4 | 5 | 6 | | - | |         ");
Console.WriteLine("             | |___|___|___| |___| |         ");
Console.WriteLine("             | | 1 | 2 | 3 | | x | |         ");
Console.WriteLine("             | |___|___|___| |___| |         ");
Console.WriteLine("             | | . | 0 | = | | / | |         ");
Console.WriteLine("             | |___|___|___| |___| |         ");
Console.WriteLine("             |_____________________|         ");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("       DRUK OP EEN KNOP OM VERDER TE GAAN    ");

            Console.ReadKey();

Console.WriteLine();
Console.WriteLine();

            Console.WriteLine("Hallo");

            for (int i = 0; i < 1; i++) {
            Thread.Sleep(2000);
         }
            Console.WriteLine("Mijn naam is Gerrit Tijhof.");

            for (int i = 0; i < 1; i++) {
            Thread.Sleep(2000);

            Console.WriteLine("En ik ga je som oplossen.");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("wat is het eerste getal?");
            firstInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstInt + ", en je tweede getal?");
            secondInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("zeg nu wat je wilt doen met de getallen " + firstInt + "." + secondInt + "?");
            Console.WriteLine(" x , / , +, -,% ");

            while(answer1)
            {
               uitvoering = Console.ReadLine();
               if (uitvoering == "x")
                {
                   //
                  answer = multiply(firstInt,secondInt);
                   Console.ReadLine();
                   answer1 = false;
                }
                else if (uitvoering == "/")
                {
                  answer = devided(firstInt,secondInt);
                   Console.ReadLine();
                   answer1 = false;
                }                                                                           
                
                else if (uitvoering == "+")
                {
                  answer =  plus(firstInt,secondInt);
                   Console.ReadLine();
                   answer1 = false;
                }
                else if (uitvoering == "-")
                {
                  answer = minus(firstInt,secondInt);
                   Console.ReadLine();
                   answer1 = false;
                }
                else if (uitvoering == "%")
                {
                  answer = modulo(firstInt,secondInt);
                   Console.ReadLine();
                   answer1 = false;
                }
                else
                {
                   Console.WriteLine("sorry daar kan ik niet mee rekenen."); 
                   answer1 = true;
                }
            }



        
        
            }
        
      }

      // X,/,+,-
      private static int multiply(int a, int b){
         int answer = a * b;
         Console.WriteLine(a + " X " + b + " = " + answer);
         return answer;
      }

      private static int devided(int a, int b){
         int answer = a / b;
         Console.WriteLine(a + " / " + b + " = " + answer);
         return answer;
      }

      private static int plus(int a, int b){
         int answer = a + b;
         Console.WriteLine(a + " + " + b + " = " + answer);
         return answer;
      }

      private static int minus(int a, int b){
         int answer = a - b;
         Console.WriteLine(a + " - " + b + " = " + answer);
         return answer;
      }

      //modulo
      private static int modulo(int a, int b){
         int answer = a % b;
         Console.WriteLine(a + " % " + b + " = " + answer);
         return answer;
      }

   }  
}
