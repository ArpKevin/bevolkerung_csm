using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas43 : Megoldas
    {
        double atlagJovedelem;
        public Megoldas43(List<Allampolgar> lakosok) : base(lakosok)
        {
            atlagJovedelem = lakosok.Average(l => l.NettoJovedelem);
        }
        public override List<string> ListaValasz()
        {
            Random r = new Random();
            var penzesTartomany = lakosok.GroupBy(l => l.Tartomany).Select(l => new { Tartomany = l.Key, LegkisebbJovedelem = l.Min(x => x.NettoJovedelem) }).Where(l => l.LegkisebbJovedelem > atlagJovedelem).Select(l => $"{l.Tartomany} {l.LegkisebbJovedelem}").ToList();
            HashSet<string> randomLista = new();
            if (penzesTartomany.Count() >= 2) while (randomLista.Count() < 2) randomLista.Add(penzesTartomany[r.Next(penzesTartomany.Count())]); else randomLista.Add("Nincs olyan tartomány, ahol a legkisebb jövedelműnek is nagyobb a keresete az átlagnál.");
            return randomLista.ToList();
        }
        public override string MondatValasz()
        {
            return $"Az átlagos nettó jövedelem {atlagJovedelem} EUR";
        }
    }
}