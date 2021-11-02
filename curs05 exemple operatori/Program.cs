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

            Console.Write("Buna ziua | login | sing up >> ");
            string optiune = Console.ReadLine();
            if (optiune == "login")
            {   
                Console.WriteLine("**********LOGARE**********");
                Console.WriteLine("Numele utilizatorului: ");
                Console.WriteLine("Parola: ");
            }
            else if(optiune == "sing up")
            {
                Console.WriteLine("**********INREGISTRARE**********");
                Console.WriteLine("Numele utilizatorului: ");
                Console.WriteLine("Adresa de email: ");
                Console.WriteLine("Creaza o parola: ");
                Console.WriteLine("Confirmare parola: ");
            }
            else
            {
                Console.WriteLine("Eroare!! Nu ai introdus nici \"login\" nici \"sing up\"");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //de aici in colo este acelas lucru doar ca in loc de IF este SWITCH

            Console.WriteLine("**********Si pentru instructinea SWICH**********");

            Console.Write("Buna ziua | login | sing up >> ");
            string optiune1 = Console.ReadLine();

            switch (optiune1)
            {
                case "login":
                    Console.WriteLine("**********LOGARE**********");
                    Console.WriteLine("Numele utilizatorului: ");
                    Console.WriteLine("Parola: ");
                    break;
                case "sing up":
                    Console.WriteLine("**********INREGISTRARE**********");
                    Console.WriteLine("Numele utilizatorului: ");
                    Console.WriteLine("Adresa de email: ");
                    Console.WriteLine("Creaza o parola: ");
                    Console.WriteLine("Confirmare parola: ");
                    break;

            }

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
