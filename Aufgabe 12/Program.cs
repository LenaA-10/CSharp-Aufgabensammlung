Random rnd = new Random();
int geheimZahl = rnd.Next(1, 101);
int zahl = 0;
Console.WriteLine("Errate die Zahl zwischen 1 und 100. Gib eine Zahl ein: ");
while (zahl != geheimZahl)
{
    Console.Write("Deine Zahl: ");
    zahl = Convert.ToInt32(Console.ReadLine());

    if (zahl < geheimZahl)
    {
        Console.WriteLine("Die Zahl ist zu klein. Versuche es erneut.");
    }
    else if (zahl > geheimZahl)
    {
        Console.WriteLine("Die Zahl ist zu gross. Versuche es erneut");
    }
    else
    {
        Console.WriteLine("Glückwunsch! Du hast die Zahl erraten.");
    }
}