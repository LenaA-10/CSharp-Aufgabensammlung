


while (true)
{
    Console.WriteLine("Ganzzahlige Dezimalzahl eingeben (oder 'q'/ 'Q'zum Beenden): ");
    string input = Console.ReadLine();

    if (input == "q" || input == "Q")
    {
        break;
    }
    if (!int.TryParse(input, out int zahl))
    {
        Console.WriteLine("Ungültige Eingabe! Bitte nur ganze Zahlen eingeben.\n");
        continue; 
    }
    string binär = "";
    while (zahl > 0)
    {
        binär = (zahl % 2) + binär;
        zahl = zahl / 2;
    }
    Console.WriteLine("Die binäre Darstellung ist: " + binär);
    
}

      





