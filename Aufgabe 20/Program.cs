using System;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.WriteLine("Make your Calculation (or press Q to quit): ");
        int Eingabe = Convert.ToInt32(Console.ReadLine());
        int Zahl = 0;

        while (Eingabe == Zahl + Zahl || Eingabe == Zahl - Zahl || Eingabe == Zahl * Zahl || Eingabe == Zahl / Zahl)
        {
            if (Eingabe == Zahl + Zahl)
            {
                 Eingabe = Zahl + Zahl;
            }
            else if (Eingabe == Zahl - Zahl)
            {
                Eingabe = Zahl - Zahl;
            }
            else if (Eingabe == Zahl * Zahl)
            {
                 Eingabe = Zahl * Zahl;
            }
            else if (Eingabe == Zahl / Zahl)
            {
                 Eingabe = Zahl / Zahl;
            }
            else { Console.WriteLine("Ungültige Eingabe! Bitte versuche es erneut: "); }
            Console.WriteLine("Das Ergebnis ist:" + Eingabe );
        }
    }
}
 