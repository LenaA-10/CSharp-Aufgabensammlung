Console.WriteLine("Berechnung von Sekunden eines Monats in Abhängigkeit seiner Anzahl Tage ");
Console.WriteLine("Wie viele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen?: ");

string input = (Console.ReadLine());
int zahl = 0;


if (int.TryParse(input, out zahl) == true)
{

    if (zahl <= 31 && zahl >= 28)
    {

        Console.WriteLine((24 * 60 * 60) * zahl);
    }
    else if (zahl > 31 || zahl < 28)
    {

        Console.WriteLine("Ein Monat kann nur maximum 28-31 Tage haben! ");
    }
}
else
{
    Console.WriteLine("Eingabefehler. Bitte geben Sie eine Zahl ein.");
}