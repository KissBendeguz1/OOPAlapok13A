using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Alapok
{
    internal class Dolgozo : Szemely
    {

        public int Ber { get; set; }

        public void Kiir() {
            Console.WriteLine($"En (${Nev}) dolgoznek ha nem it tbasznam a rezet ugye ${Ber} ");
        }
           

    }
}
