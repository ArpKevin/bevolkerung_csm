using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas45 : Megoldas
    {
        List<Allampolgar> _5EgyetemesNemBajorNo;
        List<string> nemetNemzetiseguNo;
        public Megoldas45(List<Allampolgar> lakosok) : base(lakosok)
        {
            _5EgyetemesNemBajorNo = lakosok.Where(l => l.Nem == "nő" && l.IskolaiVegzettseg == "Universität" && !(l.Nepcsoport == "bajor")).Take(5).ToList();
            nemetNemzetiseguNo = lakosok.Where(l => l.Nem == "nő" && l.Nemzetiseg == "német").Select(l => l.ToString(true)).ToList();
        }
        public override List<Allampolgar> GridValasz()
        {
            return _5EgyetemesNemBajorNo;
        }

        public override List<string> ListaValasz()
        {
            Random r = new Random();
            HashSet<string> randomLista = new();
            if (nemetNemzetiseguNo.Count() >= 3) while (randomLista.Count < 3) randomLista.Add(nemetNemzetiseguNo[r.Next(nemetNemzetiseguNo.Count())]);
            return randomLista.ToList();
        }
        public override string MondatValasz()
        {
            return (nemetNemzetiseguNo.Count() < 3) ? "Nincsen megfelelő mennyiségű német nemzetiségű nő." : "";
        }
    }
}