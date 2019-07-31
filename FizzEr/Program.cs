using System;

namespace FizzEr
{
    class Program
    {
        static void Main(string[] args)
        {
            int rounds = 0;
            Console.Write("Enter Rounds: ");

            try
            {
                rounds = Convert.ToInt16(Console.ReadLine());
            } catch(FormatException fex)
            {
                Console.WriteLine("Error Ocurred: Wrong Format");
                // TODO: Add more infor error option
            } catch (OverflowException oex)
            {
                Console.WriteLine("Error Ocurred: OverFlow Ocurred.");
                // TODO: Add more infor error option
            }

            for (var i = 1; i <= rounds; i++)
            {
                if (i % 3 == 0 && !(i % 5 == 0)) Console.WriteLine("Fizz");
                if (i % 5 == 0 && !(i % 3 == 0)) Console.WriteLine("Buzz");
                if ((i % 5 == 0) && (i % 3 == 0)) Console.WriteLine("Fizz Buzz");
                else Console.WriteLine(i);
            }

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
