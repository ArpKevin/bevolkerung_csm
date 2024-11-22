using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas14 : Megoldas
    {
        public Megoldas14(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<Allampolgar> GridValasz()
        {
            return lakosok.OrderBy(l => l.IskolaiVegzettseg).ToList();
        }
    }
}