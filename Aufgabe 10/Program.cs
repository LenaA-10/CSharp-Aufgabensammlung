Console.WriteLine("Gib eine Zahl ein um die Quersumme zu berechnen:");
int zahl = int.Parse(Console.ReadLine());
Console.WriteLine("Zahl:" + zahl);


int ergebnis = BerechneQuersumme(zahl);
Console.WriteLine("Die Quersumme ist: " + ergebnis);


static int BerechneQuersumme(int zahl) 
{ 

    int sum = 0;

    while (zahl != 0)

{
  
        sum = sum + (zahl % 10);
        zahl = zahl / 10;
       
    }
    
    return sum;
  
}
