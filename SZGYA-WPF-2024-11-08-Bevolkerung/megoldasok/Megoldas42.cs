using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas42 : Megoldas
    {
        double atlagSorFogyasztas;
        public Megoldas42(List<Allampolgar> lakosok) : base(lakosok)
        {
            atlagSorFogyasztas = lakosok.Average(l => l.ItalFogyasztasEvente).GetValueOrDefault();
        }
        public override List<string> ListaValasz()
        {
            //Random r = new Random();

            //var atlagonFeluliFogyasztok = lakosok.Where(l => l.ItalFogyasztasEvente > atlagSorFogyasztas).ToArray();
            //List<Allampolgar> randomLista = new();
            //while (!(randomLista.Count() == 5))
            //{
            //    var elem = atlagonFeluliFogyasztok[r.Next(atlagonFeluliFogyasztok.Count())];
            //    if (!(randomLista.Contains(elem))) {
            //        randomLista.Add(elem);
            //    }
            //}
            //return randomLista.Select(l => l.ToString(true)).ToList();
            Random r = new Random();
            var atlagonFeluliFogyasztok = lakosok.Where(l => l.ItalFogyasztasEvente > atlagSorFogyasztas).ToArray();
            HashSet<Allampolgar> randomLista = new();

            while (randomLista.Count < 5)
            {
                var elem = atlagonFeluliFogyasztok[r.Next(atlagonFeluliFogyasztok.Length)];
                randomLista.Add(elem);
            }

            return randomLista.Select(l => l.ToString(true)).ToList();
        }
        public override string MondatValasz()
        {
            return $"Az átlag sörfogyasztás {atlagSorFogyasztas} liter";
        }
    }
}