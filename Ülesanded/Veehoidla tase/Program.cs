
namespace Veehoidla_tase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kirjuta programm mis küsib kasutajalt kasutajanime - tsükliga ✔, meetodis ✔
            string kasutajaNimi = KasutajaNimi();
            //kui on vale kasutajanimi, programm lõppeb kasutajale teavitamisega ✔
            string correctUser = "siksseven";
            if (correctUser != kasutajaNimi) // H Ü Ü U M Ä R K
            {
                Console.WriteLine(kasutajaNimi+", Sinu nimi ei ole õige");
            }
            else
            {
                //kui on õige, küsi veetaseme hetkeseisu komakohalise arvuga - tsüklis ✔
                double veetase = 0d;
                Console.WriteLine("Tere "+correctUser+ ". Mis on veetaseme hetkeseis meetrites?: ");
                bool errorState = false;
                do
                {
                    Console.WriteLine("Mis on veetase anduril?:");
                    double andur = double.Parse(Console.ReadLine());
                    veetase = andur;
                    if (veetase < 1.00d || veetase > 4.25d)
                    {
                        errorState = true;
                        break;
                    }
                }
                while (veetase < 1.00d && veetase > 4.25d);
                //kutsu välja eraldi meetod, mille parameetriks on veetase, mis tagastab string-tüüpi andme ✔
                HoiatusSõnum(veetase, errorState);
            }
        }

        private static void HoiatusSõnum(double veetase, bool errorState)
        {
            //meetod kontrollib 3 vahemikku, ja tagastab teavituse põhinedes sellele kui kõrge vesi on
            // vahemik 1: 1-2m tase madal
            if(veetase >= 1.00d && veetase < 2.00d)
            {
                Console.WriteLine("VEETASE ON MADAL");
            }
            // vahemik 2: 2-3.5m tase normaalne
            else if (veetase >= 2.0d && veetase < 3.5d)
            {
                Console.WriteLine("veetase on normaalne PaAnIkAkS eI oLe PõHjUsT!!!!!");
            }
            // vahemik 3: 3.5-4.25m tase on üsna kõrge
            else if (veetase >= 3.5d && veetase < 4.25d)
            {
                Console.WriteLine("tase on liiga kõrge, chill...");
            }
            // kõik muu annab veateate anduri kohta.
            else
            {
                errorState = true;
                Console.WriteLine("* anduri viga, kontrolli seadet *");
            }    
        }





        private static string KasutajaNimi() 
        {
            string sisestus = "";
            do
            {
                Console.WriteLine("Palun sisesta oma kasutajanimi");
                sisestus = Console.ReadLine();
            } while (sisestus == "");
            return sisestus;
        }
    }
}
