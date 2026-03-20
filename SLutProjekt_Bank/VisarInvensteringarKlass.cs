using System;
using InvesteringarKlass;

namespace VisarInvensteringarKlassen;

public class VisarInvensteringar
{
    public static void VisaInvesteringar(ref int saldo, List<Investering> minaInvesteringar)
        {
            Console.WriteLine("===== INVESTERINGAR =====");
            Console.WriteLine("1. Lemonadstånd (500 kr, 50 kr/dag)");
            Console.WriteLine("2. Aktier (2000 kr, 200 kr/dag)");
            Console.WriteLine("3. Tillbaka");

            string val = Console.ReadLine();
            int.TryParse(val, out int investeringValet);

                if (investeringValet == 1)
                {
                    if (saldo >= 500)
                    {
                        saldo -= 500;
                        minaInvesteringar.Add(new Investering("Lemonadstånd", 500, 50));
                        Console.WriteLine("Du köpte ett Lemonadstånd!");
                    }

                    else
                    {
                        Console.WriteLine("Inte tillräckligt med pengar!");
                    }
                        Console.ReadLine();
                }

                    else if (investeringValet == 2)
                    {
                        if (saldo >= 2000)
                        {
                            saldo -= 2000;
                            minaInvesteringar.Add(new Investering("Aktier", 2000, 200));
                            Console.WriteLine("Du köpte Aktier!");
                        }
                        else
                        {
                            Console.WriteLine("Inte tillräckligt med pengar!");
                        }
                            Console.ReadLine();
                    }
        }
}
