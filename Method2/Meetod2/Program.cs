
namespace Meetod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Tervitus();
            string kasutajaNimi = "";
            Tervitus();
            kasutajaNimi = KasutajanimeKüsimine(kasutajaNimi);
            float eelarve = 0.00f;
            bool kasKasutajaNõustub = false;
            Tervitus();
            kasKasutajaNõustub = NõusolekuKüsimine(kasutajaNimi, eelarve, kasKasutajaNõustub);
            //küsi kasutajalt tema nime (tsüklis) ✅
            //küsi kasutajalt tema tulusid, niikaua kuni rohkem pole -
            //siis küsi kasutajalt tema kulusid, ka niikaua kuni rohkem pole.
            //hoia andmeid List tüüpi muutujas, andmed ise peavad olEeema komakohaga.
            //tee uus meetod, mis arvutab kokku järjendi sisu
            //hoia kogutulusid ja kogukulusid eraldi muutujates kasutades oma meetodit.
            //arvuta kasutajale tulude ja kulude põhjal tema hetkeseis.
            //Ümarda kasutajale tagastatav arv kahe komakohani. Ja kuva nimeline sõnum

        }

        private static void Tervitus()
        {
            Console.WriteLine("'OMMIK");
        }

        private static bool NõusolekuKüsimine(string kasutajaNimi, float eelarve, bool kasKasutajaNõustub)
        {
            while (kasKasutajaNõustub == false)
            {
                Console.WriteLine($"{kasutajaNimi}, kas see on sinu õige eelarve: {eelarve}");
                Console.WriteLine("Vasta kas jah või ei");
                string vastus = Console.ReadLine();
                if (vastus == "jah")
                {
                    kasKasutajaNõustub = true;
                }
                else
                {
                    kasKasutajaNõustub = false;
                }

            }

            return kasKasutajaNõustub;
        }

        private static string KasutajanimeKüsimine(string kasutajaNimi)
        {
            while (kasutajaNimi == "")
            {
                Console.WriteLine("TERRE, palun sisesta oma kasutajanimi");
                kasutajaNimi = Console.ReadLine();
            }
            Console.WriteLine("Mis on sinu nädalane eelarve?");
            return kasutajaNimi;
        }
    }
}
