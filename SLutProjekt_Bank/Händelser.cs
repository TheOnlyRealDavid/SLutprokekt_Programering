using System;
using InvesteringarKlass;
using StartKlass;
using VisarInvensteringarKlassen;

namespace NyDagKlassen;

public class NästaDag
{
    public static void DagligaHändelser(ref int saldo, List<Investering> minaInvesteringar)
    {
        int totalInkomst = 0; //Säter totalt inkostem till noll som vi sedan ändrar på, alltså den ska börja på noll varje gång metoden körs

        int aktivhändelse = Random.Shared.Next(4); // randomiserar en 1/4 chans om det kommer hända någpn spelciel händelse varje dag

        if(aktivhändelse == 3)
        {
            List<string> OlikaHändelser = ["LyckadInvestering", "MisslyckadInvestering", "EkonomiskStress", "BlomstradEkonomi"]; //En lista på olika händelser som kan hända när en ny dag händer
            string slumpadHändelse = OlikaHändelser[Random.Shared.Next(OlikaHändelser.Count)]; // randomiserar en an händelserna i listan övanför     

            if(slumpadHändelse == "LyckadInvestering")
            {
                saldo *= 5;
                Console.WriteLine("Du hadde en lyckad investering i aktier och femdublerade ditt saldo");
                Console.ReadLine();
                Console.Clear();
            }

            else if(slumpadHändelse == "MisslyckadInvestering")
            {
                saldo *= 0;
                Console.WriteLine("Dina aktier krashade och allt ditt saldo försvann");
                Console.ReadLine();
                Console.Clear();
            }

            else if(slumpadHändelse == "EkonomiskStress")
            {
                saldo -= 500;
                Console.WriteLine("Det har varit en stressig dag vilket gjorde att du gick back 500 kr");
                Console.ReadLine();
                Console.Clear();

            }

            else if(slumpadHändelse == "BlomstradEkonomi")
            {
                saldo += 2000;
                Console.WriteLine("Denna dag har blomstrad för dig och du lyckades tjäna 2000kr");
                Console.ReadLine();
                Console.Clear();
            }

        }

        else
        {
            foreach (Investering inv in minaInvesteringar)
            {
                totalInkomst += inv.InkomstPerDag; //anropar från investering
            }

            saldo += totalInkomst;

            Console.WriteLine($"Du tjänade {totalInkomst} kr idag!");
            Console.ReadLine();
            Console.Clear();  
        }


    }


}
