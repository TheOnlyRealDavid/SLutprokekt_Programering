using System;

namespace InvesteringarKlass;

public class Investering
{
    public string Namn; //Jag märke om jag köper ex. 1 lemonadstånd så kommer min inkomst bara vara ifrån lemonadstånd därför tog jag bort static
    public int Kostnad;
    public int InkomstPerDag;

    public Investering(string namn, int kostnad, int inkomstPerDag)
    {
        Namn = namn; //namn är värdet som skickas in och Namn är det som sparas i själva obejektet alltså lemonastånd eller aktier
        Kostnad = kostnad;
        InkomstPerDag = inkomstPerDag;
    }
}
