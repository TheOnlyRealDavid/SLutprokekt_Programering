using System;

namespace StartKlass;

public class Starten
{
    public static int start()
    {
        Console.WriteLine("===== BANK SIMULATOR =====");
        Console.WriteLine("Målet är att bygga upp din förmögenhet genom att spara och investera pengarna och nå 100 tusen kr. (Tryck enter för att gå vidare)");
        Console.ReadLine();
        Console.Clear();

        Console.Write("Skriv ditt namn för att skapa ett bankkonto: ");
        string namn = Console.ReadLine();
        Console.Clear();

        while(string.IsNullOrEmpty(namn))//här så kollar den om namn är 0 eller tom och om det är det så aktiveras
        {
            Console.Write("Skriv ditt namn för att skapa ett bankkonto: ");
            namn = Console.ReadLine();
            Console.Clear();
        }

        int startkapital = 1000;

        Console.WriteLine($"Välkommen {namn}! Du börjar med {startkapital} kr.");

        Console.ReadLine();
        Console.Clear();
        
        return startkapital; // Jag retunerar startkaptitalet till saldo variabeln vilket gör så jag kan använda den i andra metoder
    }
}
