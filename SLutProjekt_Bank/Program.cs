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

//======================================================================================0

using InvesteringarKlass;
using StartKlass;
using Bank;

int saldo = Starten.start(); // här sparas startkapital värdet i int saldo som start metoden retunerar

List<Investering> minaInvesteringar = new List<Investering>(); // Skpar listan som förvarar Invensteringarna innan upplevesle metoden för att jag ska kunna använda den i den metoden.

BankUpplevelsen.BankUpplevelse(saldo, minaInvesteringar); // skickar in saldo värdet i bankupplevesen metoden