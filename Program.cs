namespace OOP_Alapok
{
    internal class Program
    {

        List<Hallgato> hallgatok = new List<Hallgato>();
        static void Main(string[] args)
        {
            Hallgato hal = new Hallgato();
            hal.NeptunKod = "123456";
            hal.nev = "Jozsi";
            hal.Kiir();
            Dolgozo d = new Dolgozo();
            d.nev = "Kata";
            d.Ber = 999999999;
            d.Kiir();
            /*Szemely szemely = new Szemely();
            szemely.Nev = "katika";
            szemely.Eletkor = 150;
            Console.WriteLine(szemely);
            Bankszamla szamla = new Bankszamla();
            szamla.Betesz(30000);
            szamla.Kivesz(8765);
            Console.WriteLine(szamla);*/


        }
    }
}
