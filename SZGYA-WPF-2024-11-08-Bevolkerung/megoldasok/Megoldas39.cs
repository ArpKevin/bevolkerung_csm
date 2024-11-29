using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas39 : Megoldas
    {
        public Megoldas39(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            return lakosok.GroupBy(l => l.Tartomany).ToDictionary(l => l.Key, l => l.Max(x => x.NettoJovedelem)).OrderByDescending(l => l.Value).Select(l => $"{l.Key}, {l.Value}").ToList();
        }
    }
}