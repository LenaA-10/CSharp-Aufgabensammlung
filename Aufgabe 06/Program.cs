Console.WriteLine("Kleines 1 x 1");

int zeile = 1;
while (zeile <= 10) 
{
    int spalte = 1;
    while (spalte <= 10) 

    {
        Console.Write((zeile * spalte) + "\t");
        spalte++;
    }

    Console.WriteLine();

    zeile++;
}
Console.ReadLine();