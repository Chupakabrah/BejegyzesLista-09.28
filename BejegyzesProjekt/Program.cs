using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            var bejegyzes = new Bejegyzes("Jenő", "Jenő tartalma! lel");
            List<Bejegyzes> bejegyzesek = new List<Bejegyzes>();
            bejegyzesek.Add(bejegyzes);
            Console.Write("Kérem adja meg, hány bejegyzést akar létrehozni : ");
            int db = Convert.ToInt32(Console.ReadLine());
            string listSzerzo, listTartalom;
            int lepteto;
            Random rnd = new Random();
            //StreamReader olvas = new StreamReader("bejegyzesek.txt");

            do
            {
                Console.Write("Kérem a szerzőt : ");
                listSzerzo = Console.ReadLine();
                Console.Write("Kérem a bejegyzést : ");
                listTartalom = Console.ReadLine();
                bejegyzesek.Add(new Bejegyzes(listSzerzo, listTartalom));
                db--;
            } while (db != 0);
            Console.WriteLine();
            for (int i = 0; i < bejegyzesek.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + bejegyzesek[i].Kiir());
            }

            Console.WriteLine("Bejegyzés módosításához írja be a bejegyzés számát!");
            int szerzo = Convert.ToInt32(Console.ReadLine()) - 1;
            if (bejegyzesek.Contains(bejegyzesek[szerzo]))
            {
                Console.WriteLine(bejegyzesek[szerzo].tartalom);
                Console.WriteLine();
                Console.WriteLine("Kérem írja át a tartalmat : ");
                bejegyzesek[szerzo].tartalom = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ilyen indexű szerző nem létezik!");
            }

            lepteto = bejegyzesek.Count * 20;
            do
            {
                bejegyzesek[rnd.Next(bejegyzesek.Count)].Like();
                lepteto--;
            } while (lepteto > 0);

            

            for (int i = 0; i < bejegyzesek.Count; i++)
            {
                
            }

            foreach (var item in bejegyzesek)
            {
                Console.WriteLine(item.Kiir());
            }

            bejegyzes.Kiir();
            Console.ReadKey();
        }
    }
}
