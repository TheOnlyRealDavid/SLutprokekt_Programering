using System;

namespace StartKlass;

public class Starten
{
    public static int start()
    {
        Console.WriteLine("===== BANK SIMULATOR =====");
        Console.WriteLine("Målet är att bygga upp din förmögenhet genom att spara och investera pengarna och nå 1 miljon kr.");
        Console.WriteLine();

        Console.Write("Skriv ditt namn för att skapa ett bankkonto: ");
        string namn = Console.ReadLine();

        int startkapital = 1000;

        Console.WriteLine($"Välkommen {namn}! Du börjar med {startkapital} kr.");

        Console.ReadLine();
        Console.Clear();
        
        return startkapital; // Jag retunerar startkaptitalet till saldo variabeln vilket gör så jag kan använda den i andra metoder
    }
}
