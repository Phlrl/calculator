using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace calculator
{
    class Taschenrechner
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1 = Addieren");
            Console.WriteLine("2 = Subtrahieren");
            Console.WriteLine("3 = Multiplizieren");
            Console.WriteLine("4 = Dividieren");

            Console.Write("Auswahl: ");
            int Auswahl = Convert.ToInt32(Console.ReadLine());

            switch (Auswahl)
            {
                case 1:
                    AddierenEingaben();
                    break;

                case 2:
                    SubtrahierenEingabe();
                    break;

                case 3:
                    MultiplkationEingabe();
                    break;

                case 4:
                    DividierenEingabe();
                    break;
            }
        }


        class Plus();
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
        }

        public static int Addieren(int Summand1, int Summand2)
        {
            int Summe = Summand1 + Summand2;
            return Summe;
        }

        class Minus();

        public static void SubtrahierenEingabe()
        {
            Console.WriteLine("Minuend :");
            string eingabe = Console.ReadLine();
            int Minuend = Int32.Parse(eingabe);

            Console.WriteLine("Subtrahend :");
            eingabe = Console.ReadLine();
            int Subtrahend = Int32.Parse(eingabe);
            int Differenz = Subtrahieren(Minuend, Subtrahend);

            Console.WriteLine(Differenz);
        }

        public static int Subtrahieren(int Minuend, int Subtrahend)
        {
            int Differenz = Minuend - Subtrahend;
            return Differenz;
        }

        class Mal();

        public static void MultiplkationEingabe()
        {
            Console.WriteLine("Faktor 1 :");
            string eingabe = Console.ReadLine();
            int Faktor1 = Int32.Parse(eingabe);

            Console.WriteLine("Faktor 2 :");
            eingabe = Console.ReadLine();
            int Faktor2 = Int32.Parse(eingabe);
            int Produkt = Multiplizieren(Faktor1, Faktor2);

            Console.WriteLine(Produkt);
        }

        public static int Multiplizieren(int Faktor1, int Faktor2)
        {
            int Produkt = Faktor1 * Faktor2;
            return Produkt;
        }

        class Durch();

        public static void DividierenEingabe()
        {
            Console.WriteLine("Dividend :");
            string eingabe = Console.ReadLine();
            int Dividend = Int32.Parse(eingabe);

            Console.WriteLine("Divisor :");
            eingabe = Console.ReadLine();
            int Divisor = Int32.Parse(eingabe);
            int Quotient = Dividieren(Dividend, Divisor);

            Console.WriteLine(Quotient);
        }

        public static int Dividieren(int Dividend, int Divisor)
        {
            int Quotient = Dividend/Divisor;
            return Quotient;
        }

    }
}
