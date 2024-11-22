using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas26 : Megoldas
    {
        public Megoldas26(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            var atlagosEletkorTartomanyonkent = lakosok
            .GroupBy(l => l.Tartomany)
            .Select(l => new
            {
                Tartomany = l.Key,
                AtlagEletkor = l.Average(l => l.Eletkor)
            });

            return atlagosEletkorTartomanyonkent.Select(l => $"{l.Tartomany} {l.AtlagEletkor}").ToList();
        }
    }
}