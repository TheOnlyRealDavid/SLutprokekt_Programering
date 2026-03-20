using System;

namespace InvesteringarKlass;

public class Investering
{
    public static string Namn;
    public static int Kostnad;
    public static int InkomstPerDag;

    public Investering(string namn, int kostnad, int inkomstPerDag)
    {
        Namn = namn;
        Kostnad = kostnad;
        InkomstPerDag = inkomstPerDag;
    }
}
