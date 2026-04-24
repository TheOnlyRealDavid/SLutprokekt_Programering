using System;
using InvesteringarKlass;

namespace VisarInvensteringarKlassen;

public class VisarInvensteringar
{
    public static void VisaInvesteringar(ref int saldo, List<Investering> minaInvesteringar)
        {
            Console.WriteLine("===== INVESTERINGAR =====");
            Console.WriteLine("1. Lemonadstånd (500 kr, 50 kr/dag)");
            Console.WriteLine("2. Aktier (2000 kr, 350 kr/dag)");
            Console.WriteLine("3. Tillbaka");

            string val = Console.ReadLine();
            int.TryParse(val, out int investeringValet);

                if (investeringValet == 1)
                {
                    Console.Write("Hur många lemonadstånd vill du köpa? ");
                    string hurMånga = Console.ReadLine(); //skriver in hur många lemonadstån man vill ha
                    int.TryParse(hurMånga, out int antal);
                    Console.Clear();

                    int kostnad = antal * 500;

                    if (antal > 0 && saldo >= kostnad) // om antal är större än 0 ock du har mer pengar än vad kostar kommer det gå vidare
                    {
                        saldo -= kostnad;

                        for (int i = 0; i < antal; i++) //lägger till ett lemonadstånd till i blir = antalet du valde
                        {
                            minaInvesteringar.Add(new Investering("Lemonadstånd", 500, 50));
                        }

                        Console.WriteLine($"Du köpte {antal} Lemonadstånd!");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else
                    {
                        Console.WriteLine("Ogiltigt antal eller inte tillräckligt med pengar!");
                        Console.ReadLine();
                        Console.Clear();
                    }

                }

                else if (investeringValet == 2)
                {
                    Console.Write("Hur många aktier vill du köpa? ");
                    string hurMånga = Console.ReadLine(); //skriver in hur många aktier man vill ha
                    int.TryParse(hurMånga, out int antal);
                    Console.Clear();

                    int kostnad = antal * 2000;

                    if (antal > 0 && saldo >= kostnad) // om antal är större än 0 och du har mer pengar än vad det kostar
                    {
                        saldo -= kostnad;

                        for (int i = 0; i < antal; i++) //lägger till aktier beroende på antal valda
                        {
                            minaInvesteringar.Add(new Investering("Aktier", 2000, 350));
                        }

                        Console.WriteLine($"Du köpte {antal} Aktier!");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else
                    {
                        Console.WriteLine("Ogiltigt antal eller inte tillräckligt med pengar!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
        }
}
