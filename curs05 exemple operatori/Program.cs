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

            Console.WriteLine("Te rog sa introduci un cuvant: ");
            string cuvant = Console.ReadLine();
            
            for(int i = 0; i < cuvant.Length; i++)
            {
                Console.Write(cuvant[i]+" ");
            }
            Console.WriteLine();
            for (int i = cuvant.Length-1; i >= 0 ; i--)
            {
                Console.Write(cuvant[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Cuvantul introdus are: {cuvant.Length}");
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
