using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas25 : Megoldas
    {
        public Megoldas25(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<Allampolgar> GridValasz()
        {
            return lakosok.Where(l => l.KrumpliFogyasztasEvente > lakosok.Average(x => x.KrumpliFogyasztasEvente)).OrderBy(l => l.KrumpliFogyasztasEvente).Take(15).ToList();
        }
    }
}