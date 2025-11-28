namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int arv = 67;
            //string arvtekstina = arv.ToString();
            //Console.WriteLine(arvtekstina);
            //Console.WriteLine(arv);
            //double arvdouble = 7236457.862379d;
            //int arvdoublearvint = 0;

            //arvdoublearvint = (int)arvdouble;

            //double uusdouble = arv;

            //kirjuta programm mis küsib kasutajalt meetrites tema pikkust (komakohtadega)
            //string pikkus = "";
            //Console.WriteLine("sisesta pikkus:");
            //pikkus = Console.ReadLine();
            //float pikkusFm = float.Parse(pikkus);
            //int pikkusCm = (int)(pikkusFm*100);
            //Console.WriteLine($"Sinu pikkus CMides on {pikkusCm}, ja meetrites{pikkusFm}");

            //teisenda kasutaja pikkus sentimeetriteks.

            //küsimine esialgu on tekstikujul (kasutaja sisestab teksti),

            //programm ise peab tekstist välja lugema komakohaga arvu.

            float arv1 = 0.45f;
            float arv2 = 0.55f;
            Console.WriteLine(arv1);
            Console.WriteLine(arv2);
            Console.WriteLine((int)arv1);
            Console.WriteLine((int)arv2);
            Console.WriteLine(Math.Round(arv1));
            Console.WriteLine(Math.Round(arv2));
        }
    }
}
