using System;

namespace curs05_exemple_operatori
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintMessageIfExist("message1", "alt message 1");
            //PrintMessageIfExist(null, "alt message 1");
            //Print("text abc");
            string userName = "Iosif";
            string password = "Turcu";
            Console.Write("Username: ");
            string userInput = Console.ReadLine();
            Console.Write("Password: ");
            string passwordInput = Console.ReadLine();

            while(userInput != userName || passwordInput != password)
            {
                Console.WriteLine("Datele nu sunt corecte !!");
                Console.Write("Username: ");
                userInput = Console.ReadLine();
                Console.Write("Password: ");
                passwordInput = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Bine ai venit {userInput}");
        }

        static void PrintMessageIfExist(string message, string alternative)
        {
            string finalMassage = message ?? alternative;
            Console.WriteLine(finalMassage);
        }

        static void Print(string text)
        {
            string parameterName = nameof(text);
            if (text is null)
            {
                Console.WriteLine($"The parameter {parameterName} was null.");
            }
            else
            {
                Console.WriteLine($"Message= {parameterName}");
            }
        }

    }
}
