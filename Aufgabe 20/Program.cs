using System;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.WriteLine("Make your Calculation (or press Q to quit): ");
        string Eingabe = Console.ReadLine();
        int Zahl = 5; 

        while (Eingabe != "Q" && Eingabe != "q")
        {
            if (Eingabe == Zahl + "+" + Zahl)
            {
                int ergebnis = Zahl + Zahl;
                Console.WriteLine("Das Ergebnis ist: " + ergebnis);
            }
            else if (Eingabe == Zahl + "-" + Zahl)
            {
                int ergebnis = Zahl - Zahl;
                Console.WriteLine("Das Ergebnis ist: " + ergebnis);
            }
            else if (Eingabe == Zahl + "*" + Zahl)
            {
                int ergebnis = Zahl * Zahl;
                Console.WriteLine("Das Ergebnis ist: " + ergebnis);
            }
            else if (Eingabe == Zahl + "/" + Zahl) 
            {
                 int ergebnis = Zahl / Zahl;
                Console.WriteLine("Das Ergebnis ist: " + ergebnis);
            }
            else {
                Console.WriteLine("Ungültige Eingabe! Bitte versuche es erneut: "); 
            }
            Console.WriteLine(" ");
            Eingabe = Console.ReadLine();
        }
    }
}
 