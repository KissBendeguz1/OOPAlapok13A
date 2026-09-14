using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Alapok
{
    public class Szemely
    {
        protected string Nev; /*{ get; set; }*/
        public int Eletkor { get; set;  }
        /*
        public override string ToString()
        {
            return $"{Nev} + {Eletkor}";
        }*/


        
        public string nev
        { 
            get { return Nev; }
            set { Nev = value; }
        }
        /*
        public int eletkor
        { 
            get { return Eletkor; } 
            set { Eletkor = value; } 
        }*/
        /*
        public Szemely(string nev, int eletkor)
        {
            Nev = nev;
            Eletkor = eletkor;
        }*/
        /*
        public void Kiir()
        {
            Console.WriteLine($"{Nev} + {Eletkor}");
        }*/
    }
}
