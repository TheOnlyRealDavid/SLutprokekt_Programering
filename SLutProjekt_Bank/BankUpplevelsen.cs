using System;
using InvesteringarKlass;
using VisarInvensteringarKlassen;
using NyDagKlassen;

namespace Bank;

public class BankUpplevelsen
{
    public static void BankUpplevelse(int saldo, int startkapital ,List<Investering> minaInvesteringar) // Jag behöver hämta saldo variabeln från start metoden
    {
        bool spela = true; //Har en bool för att man ska kunna stänga av spelet när man vill genom att välja 4. avsluta

        while (spela == true)
        {

            if (saldo < 0) //avslutar spelet om du tar slut på alla dina pengar
            {   
                int totalTjänat = Math.Max(0, saldo - startkapital);

                Console.WriteLine("Du har gått i konkurs! Spelet är slut.");
                Console.WriteLine($"Du tjänade totalt {totalTjänat} kr");
                Console.WriteLine($"Antal investeringar: {minaInvesteringar.Count}"); //visar hur många invensteringar du har köpt
                Console.ReadLine();
                spela = false;
            }

            else if (saldo >= 100000) // vinner speler när du har nåt 100 tusen kr
            {   
                int totalTjänat = Math.Max(0, saldo - startkapital);

                Console.WriteLine("Grattis! Du har nått 100 000 kr och vunnit spelet!");
                Console.WriteLine($"DU tjänade totalt: {totalTjänat} kr");
                Console.WriteLine($"Antal investeringar: {minaInvesteringar.Count}"); //visar hur många invensteringar du har köpt
                spela = false;
            }

            Console.WriteLine("===== DIN BANK =====");
            Console.WriteLine("1. Visa saldo");
            Console.WriteLine("2. Visa Uppgraderingar/Invensteringar");
            Console.WriteLine("3. Nästa Dag");
            Console.WriteLine("4. Avsluta");
            Console.WriteLine("Skriv siffran på vad du vill göra");
            string BankValen = Console.ReadLine();
            int.TryParse(BankValen, out int BankValet);

                while(BankValet < 1 || BankValet > 4)
                {
                    Console.WriteLine("Du måste skriva en siffra på vad du vill göra, 1-4");
                    BankValen = Console.ReadLine();
                    int.TryParse(BankValen, out BankValet);
                    Console.Clear();
                    
                }

    //========================================
    // BankValet 1 (Visar saldo)
    //----------------------------------------


            if(BankValet == 1)
            {
                Console.WriteLine($"Du har ett Saldo på {saldo} kr");
                Console.ReadLine();
                Console.Clear();
            }

    //========================================
    // BankValet 2 (Invensteringar)
    //----------------------------------------

            else if(BankValet == 2)
            {
                VisarInvensteringar.VisaInvesteringar(ref saldo, minaInvesteringar);
                Console.Clear();
            }

    //========================================
    // BankValet 3 (Nästa dag)
    //----------------------------------------

            else if(BankValet == 3)
            {
                NästaDag.DagligaHändelser(ref saldo, minaInvesteringar);
                Console.Clear();
            }

    //========================================
    // BankValet 4 (avsluta spelet)
    //----------------------------------------

            else if(BankValet == 4)
            {
                spela = false;
                Console.Clear();
            }
        }
        
    }


}
