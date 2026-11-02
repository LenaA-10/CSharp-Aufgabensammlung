
using System;
using System.Linq;
class Program
{
    static void Main()
    {

        Console.WriteLine("Gib ein Wort oder einen Satz ein:");
        string Eingabe = Console.ReadLine();
        string vowels = "aeiouAEIOUäÄöÖüÜ";


        if (vowels.Any(Eingabe.Contains))
        {
            int count = Eingabe.Count(c => vowels.Contains(c));
            Console.WriteLine($"Die Anzahl der Vokale in '{Eingabe}' beträgt: {count}");
        }
        else
        {
            Console.WriteLine("In diesem Satz gibt es keine Vokale");
        }
    }
}
       