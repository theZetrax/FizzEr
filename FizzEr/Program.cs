using System;

namespace FizzEr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Rounds: ");
            try
            {
                short rounds = Convert.ToInt16(Console.ReadLine());
            } catch(FormatException fex)
            {
                Console.WriteLine("Error Ocurred: Wrong Format");
                return;
            } catch (OverflowException oex)
            {
                Console.WriteLine("Error Ocurred: OverFlow Ocurred");
            }

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
