using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas38 : Megoldas
    {
        public Megoldas38(List<Allampolgar> lakosok) : base(lakosok)
        {}
        public override string MondatValasz()
        {
            return $"Nők száma: {lakosok.Count(l => l.Nem == "nő")}, férfiak száma: {lakosok.Count(l => l.Nem == "férfi")}";
        }
    }
}