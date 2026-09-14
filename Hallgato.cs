using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Alapok
{
    internal class Hallgato : Szemely
    {
        private string npkod;
        public string NeptunKod 
        {
            get { return npkod; }
            set { if (value.Length <= 6) { npkod = value; } }
        }

        public void Kiir()
        {
            Console.WriteLine($"En (${nev}) tanulnek ha nem it tbasznam a rezet ugye ${NeptunKod} ");
        }



    }
}
