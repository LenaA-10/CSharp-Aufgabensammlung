Console.WriteLine("Was ist die Anzahl km?: ");
string input = (Console.ReadLine());
int n = 0;
if (int.TryParse(input, out int km))
{
    if (km > 42)
    {
     
        Console.WriteLine("Das kannst du nicht! ");
    }
    else
    {
        n = (km * 1000) / 400;
        Console.WriteLine("Das sind" + n + "Runden. Bereit für den Lauf? ");
    }
    Console.WriteLine("Bereit? (ja/nein): ");
    string bereit = (Console.ReadLine());
    if (bereit == "ja")
    {
        int i = 1;
        while (i <= n)
        {

            Console.WriteLine("Du läufst Runde " + i);
            i++;

        }
    }

}
    

