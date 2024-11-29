using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas32 : Megoldas
    {
        public Megoldas32(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            return lakosok.GroupBy(x => x.Nemzetiseg).OrderByDescending(x => x.Count()).Select(x => x.Key).ToList();
        }
    }
}