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
            int sista = 0;
            artlista[sista] = new Art("Hepatica nobilis", "Ranunculaceae", "Blåsippa");
            sista++;
            artlista[sista] = new Art("Anemone nemorosa", "Ranunculaceae", "Vitsippa");
            sista++;
            artlista[sista] = new Art("Taraxacum ruderalia", "Asteraceae", "Maskros");
            sista++;
            artlista[sista] = new Art("Malus domestica", "Rosales", "Äppelträd");
            sista++;
            artlista[sista] = new Art("Pinus sylvestris", "Pinaceae", "Tall");
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
                        Console.WriteLine($"{artlista[i].svenska,-12}  {artlista[i].art,-24} fam.: {artlista[i].familj,-30}");
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
                    Art A = new Art(artnamn, familjenamn, svensktNamn);
                    artlista[sista] = A;
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