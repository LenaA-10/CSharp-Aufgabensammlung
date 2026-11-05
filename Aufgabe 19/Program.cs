
using System;
using System.Linq;
class Program
{
    static void Main()
    {

        Console.WriteLine("Gib ein Wort oder einen Satz ein:");
        string eingabe = (Console.ReadLine());
        string vowels = "aeiouAEIOUäÄöÖüÜ";


        if (vowels.Any(eingabe.Contains))
        {
            int count = eingabe.Count(c => vowels.Contains(c));
            Console.WriteLine($"Die Anzahl der Vokale in '{eingabe}' beträgt: {count}");
        }
        else
        {
            Console.WriteLine("In diesem Satz gibt es keine Vokale");
        }
    }
}
       