Random rnd = new Random();
int tal = rnd.Next(1, 101);
int antal = 0;
int gissning;
Console.WriteLine("Gissa talet mellan 1 och 100:");
do
{
    gissning = Convert.ToInt32(Console.ReadLine());
    antal++;
    if (gissning > tal)
        Console.WriteLine("Du gissar för högt. Försök igen:");
    else if (gissning < tal)
        Console.WriteLine("Du gissar för lågt. Försök igen:");
    else
    {
        Console.WriteLine("Rätt svar!!!");
        Console.WriteLine("Antal försök: " + antal);
    }

} while (gissning != tal);
