using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas1 : Megoldas
    {
        public Megoldas1(List<Allampolgar> lakosok) : base(lakosok)
        {
        }

        public override string MondatValasz()
        {
            return $"A legmagasabb nettó éves jövedelem: {lakosok.Max(l => l.NettoJovedelem)} EUR";
        }
    }
}
