namespace mju23h_dtp_genrep_FAS2
{
    class Art
    {
        public string art, familj, svenska;
        public Art(string art, string familj, string svenska)
        {
            this.art = art;
            this.familj = familj;
            this.svenska = svenska;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Art[] artlista = new Art[100];
            string[] art = new string[100];
            string[] familj = new string[100];
            string[] sv = new string[100];
            int sista = 0;
            artlista[0] = new Art("Hepatica nobilis", "Ranunculaceae", "Blåsippa");
            // sista++;
            art[sista] = "Anemone nemorosa";
            familj[sista] = "Ranunculaceae";
            sv[sista] = "Vitsippa";
            sista++;
            art[sista] = "Taraxacum ruderalia";
            familj[sista] = "Asteraceae";
            sv[sista] = "Maskros";
            sista++;
            art[sista] = "Malus domestica";
            familj[sista] = "Rosales";
            sv[sista] = "Äppelträd";
            sista++;
            art[sista] = "Pinus sylvestris";
            familj[sista] = "Pinaceae";
            sv[sista] = "Tall";
            sista++;
            Console.WriteLine("Hej och välkommen till artdatabasen!");
            Console.WriteLine("Skriv 'hjälp' för hjälp, 'sluta' för att sluta!");
            while (true)
            {
                // FIXME: 
                // >>> List i stället för array!!
                // klass i STÄLLET FÖR sträng-arrayer
                // 
                // en Input i stället för Console.Write/Console.ReadLine
                // kan bryta ut metoder, t.ex. för "ny"
                Console.Write("kommando: ");
                string kommando = Console.ReadLine();
                if (kommando == "sluta")
                {
                    break;
                }
                else if (kommando == "hjälp")
                {
                    Console.WriteLine("hjälp     - lista kommandona");
                    Console.WriteLine("lista     - lista alla arter");
                    // FIXME: sluta
                }
                else if (kommando == "lista")
                {
                    for (int i = 0; i < sista; i++)
                    {
                        Console.WriteLine($"{sv[i],-12}  {art[i],-24} fam.: {familj[i],-30}");
                    }
                }
                else if (kommando == "ny")
                {
                    Console.Write("artnamn: ");
                    string artnamn = Console.ReadLine();
                    Console.Write("familj:  ");
                    string familjenamn = Console.ReadLine();
                    Console.Write("svenska: ");
                    string svensktNamn = Console.ReadLine();
                    art[sista] = artnamn; familj[sista] = familjenamn; sv[sista] = svensktNamn;
                    sista++;
                    Console.WriteLine($"{artnamn} tillagd");
                }
                else
                {
                    Console.WriteLine($"Vaddå '{kommando}'?");
                }
            }
            Console.WriteLine("Hej då!");
        }
    }
}