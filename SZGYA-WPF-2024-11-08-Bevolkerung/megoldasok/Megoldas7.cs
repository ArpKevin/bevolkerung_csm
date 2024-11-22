using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas7 : Megoldas
    {
        public Megoldas7(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<Allampolgar> GridValasz()
        {
            return lakosok.Where(l => l.Tartomany == "Bajorország" && l.NettoJovedelem >= 30000).OrderBy(x=>x.IskolaiVegzettseg).ToList();
        }
    }
}
