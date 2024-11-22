using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas5 : Megoldas
    {
        public Megoldas5(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<Allampolgar> GridValasz()
        {
            return lakosok.Where(l => l.Eletkor == lakosok.Min(x => x.Eletkor)).ToList();
        }
    }
}
