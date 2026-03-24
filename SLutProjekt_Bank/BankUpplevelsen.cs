using System;
using InvesteringarKlass;
using VisarInvensteringarKlassen;
using NyDagKlassen;

namespace Bank;

public class BankUpplevelsen
{
    public List<Investering> minaInvesteringar = new List<Investering>(); // Skpar listan som förvarar Invensteringarna innan upplevesle metoden för att jag ska kunna använda den i den metoden.
    public static void BankUpplevelse(int saldo, List<Investering> minaInvesteringar) // Jag behöver hämta saldo variabeln från start metoden
    {
        bool spela = true; //Har en bool för att man ska kunna stänga av spelet när man vill genom att välja 4. avsluta

        while (spela == true)
        {
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
                    
                }

    //========================================
    // BankValet 1 (Visar saldo)
    //----------------------------------------


            if(BankValet == 1)
            {
                Console.WriteLine($"Du har ett Saldo på {saldo} kr");
                Console.ReadLine();
            }

    //========================================
    // BankValet 2 (Invensteringar)
    //----------------------------------------

            else if(BankValet == 2)
            {
                VisarInvensteringar.VisaInvesteringar(ref saldo, minaInvesteringar);
            }

    //========================================
    // BankValet 3 (Nästa dag)
    //----------------------------------------

            else if(BankValet == 3)
            {
                NästaDag.DagligaHändelser(saldo, minaInvesteringar);
            }

    //========================================
    // BankValet 4 (avsluta spelet)
    //----------------------------------------

            else if(BankValet == 4)
            {
                spela = false;
            }
        }
        
    }


}
