using System;

namespace onlineStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = "Hello Welcome!";

            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Today Is : " + DateTime.Now);
            Console.ResetColor();
            Console.WriteLine("Here are some of the products we have availale right now...");

            string product = "Computer";
            int price = 1500;
            bool available = true;
            float weight = 2.5f;
           
            if (available == true)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{product} is avalibe!!         ");
                Console.WriteLine($"The " + product + " is " + price + " dollars $");
                Console.WriteLine($"It weights " + weight + " kg             ");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{product} is unavalibe!!");
            }

            Console.ReadKey();
        }
    }
}
