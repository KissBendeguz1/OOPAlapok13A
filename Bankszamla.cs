using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Alapok
{
    internal class Bankszamla
    {
        public uint Egyenleg { get; set; }

        public void Betesz(uint osszeg) {
            Egyenleg += osszeg;
        }

        public void Kivesz(uint osszeg) {
            if (Egyenleg > osszeg)
            {
                Egyenleg -= osszeg;
            }
            else
            {
                Console.WriteLine("Nincs eleg money");
            }
            
        }

        public override string ToString()
        {
            return $"Az aktualis egyenleg: {Egyenleg} értékálló magyar forint";
        }
    }
}
