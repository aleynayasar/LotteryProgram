using System;

namespace LotteryProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            do
            {
                Console.WriteLine(" ***** LOTTERY PROGRAM ***** ");
                Console.Write("How many people will participate in the draw: ");
                int numberOfPeople = int.Parse(Console.ReadLine());

                string[] participantList = new string[numberOfPeople];

                for (int i = 0; i < participantList.Length; i++)
                {
                    Console.Write("Enter name : ");
                    participantList[i] = Console.ReadLine();


                }

                int kuraSiralamasi = new Random().Next(0, participantList.Length - 1);

                Console.WriteLine("Winning : {0}", participantList[kuraSiralamasi]);
                Console.WriteLine("If you want to start a new lottery press 1 :");
                selection = int.Parse(Console.ReadLine());
                Console.Clear();

            } while (selection == 1);

            if (selection != 1)

                Console.WriteLine("\aThe lottery cannot be restarted. Please try again.");

            Console.ReadKey();
        }

    }
}
