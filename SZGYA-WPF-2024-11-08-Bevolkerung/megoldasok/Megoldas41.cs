using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas41 : Megoldas
    {
        public Megoldas41(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<Allampolgar> GridValasz()
        {
            Random r = new Random();
            return lakosok.Where(l => l.Nemzetiseg == "török" && l.AktivSzavazo).Take(r.Next(11)).ToList();
        }
    }
}