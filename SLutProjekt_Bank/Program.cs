// Start
// Användaren presenteras till Bank Simulator med en titel och en kort beskrivning om att målet är att bygga upp sin förmögenhet.
// Användaren får skriva in sitt namn för att skapa sitt bankkonto.
// Användaren börjar med ett visst startkapital på sitt konto.


// Bankupplevelsen
// Användaren befinner sig i sin digitala bank och får välja vad hen vill göra.
// Användaren kan välja att visa sitt saldo.
// Användaren kan välja att vida möjliga uppgraderingar och invensteringar.
// Användaren kan välja att gå till nästa dag;
// Användaren kan Välja att Avsluta spelet.


// Investeringar
// När användaren väljer att investera får hen välja mellan olika typer av investeringar.
// Varje investering kostar olika mycket pengar.
// Om användaren har tillräckligt med pengar genomförs köpet och läggs till i en lista över investeringar.
// Om användaren inte har tillräckligt med pengar visas ett meddelande.


// Pengagenerering
// Användaren kan välja att gå vidare till nästa dag.
// När en ny dag startar genererar varje investering pengar.
// Beroende på investeringstyp tjänar användaren olika mycket pengar.
// De intjänade pengarna läggs till saldot.


// Händelser
// Det kan slumpas fram positiva eller negativa ekonomiska händelser.
// Användaren kan exempelvis tjäna extra pengar eller förlora pengar.
// Saldot uppdateras beroende på händelsen.


// Slut
// Programmet fortsätter tills användaren väljer att avsluta.
// När användaren avslutar visas en sammanfattning av saldo och investeringar.
// Programmet tackar användaren för att hen spelat Bank Simulator.



//====================================================================================
// START
//-----------------------------------------------------------------------------------

int saldo = start(); // här sparas startkapital värdet i int saldo som start metoden retunerar
BankUpplevelse(saldo); // skickar in saldo värdet i bankupplevesen metoden

 static int start()
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

//===============================================================================================
// Bankuppleveslen
//-----------------------------------------------------------------------------------------------

static void BankUpplevelse(int saldo) // Jag behöver hämta saldo variabeln från start metoden
{
    bool spela = true;

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


        if(BankValet == 1)
        {
            Console.WriteLine($"Du har ett Saldo på {saldo} kr");
            Console.ReadLine();
        }

        else if(BankValet == 2)
        {
            Console.WriteLine("===== INVESTERINGAR =====");
            Console.WriteLine("1. Lemonadstånd (kostar 500 kr, tjänar 50 kr/dag)");
            Console.WriteLine("2. Aktier (kostar 2000 kr, tjänar 200 kr/dag)");
            Console.WriteLine("3. Tillbaka");

            string Invensteringsval = Console.ReadLine();
            int.TryParse(Invensteringsval, out int investeringValet);

            if(investeringValet == 1)
            {
                if(saldo >= 500)
                {
                    saldo -= 500;
                    Console.WriteLine("Du köpte ett Lemonadstånd!");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Du har inte tillräckligt med pengar!");
                    Console.ReadLine();
                }
            }

            if(investeringValet == 2)
            {
                if(saldo >= 2000)
                {
                    saldo -= 2000;
                    Console.WriteLine("Du köpte ett Aktier!");
                    Console.ReadLine();
                }
                
                else
                {
                    Console.WriteLine("Du har inte tillräckligt med pengar!");
                    Console.ReadLine();
                }
            }
        }

        else if(BankValet == 3)
        {
            Console.WriteLine("Du valde 3");
            Console.ReadLine();
        }

        else if(BankValet == 4)
        {
            spela = false;
        }
    }
    
}


