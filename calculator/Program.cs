using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace calculator
{
    internal class Taschenrechner
    {

        static void Main(string[] args)
        {
            AddierenEingaben();
        }

        public static void AddierenEingaben()
        {
            Console.WriteLine("Summand 1 :");
            string eingabe = Console.ReadLine();
            int summannd1 = Int32.Parse(eingabe);

            Console.WriteLine("Summand 2 :");
            eingabe = Console.ReadLine();
            int summannd2 = Int32.Parse(eingabe);
            int summe = Addieren(summannd1, summannd2);

            Console.WriteLine(summe);
            Thread.Sleep(10000);
        }

        public static int Addieren(int Summand1, int Summand2)
        {
            int Summe = Summand1 + Summand2;
            return Summe;
        }
    }
}
