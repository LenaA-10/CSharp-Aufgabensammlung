
Console.WriteLine("Dieses Programm berechnet die Summe von zwei Zahlen.");

Console.WriteLine("Gib die erste Zahl ein: ");
string Eingabe1 = (Console.ReadLine());
int Zahl1 = Convert.ToInt32(Eingabe1);

Console.WriteLine("Gib die zweite Zahl ein: ");
string Eingabe2 = (Console.ReadLine());
int Zahl2 = Convert.ToInt32(Eingabe2);

int summe = Zahl1 + Zahl2;

Console.WriteLine("Die Summe ist: " + summe);


