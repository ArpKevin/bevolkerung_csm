using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas4 : Megoldas
    {
        public Megoldas4(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<Allampolgar> GridValasz()
        {
            return lakosok.Where(l => l.Nemzetiseg == "angolai").ToList();
        }
    }
}
