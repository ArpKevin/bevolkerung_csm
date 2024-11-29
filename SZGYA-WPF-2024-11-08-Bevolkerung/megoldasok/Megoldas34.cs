using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas34 : Megoldas
    {
        public Megoldas34(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            return $"Az 55 kg krumplifogyasztást meghaladó férfiak közötti átlag súly {lakosok.Where(l => l.KrumpliFogyasztasEvente > 55 && l.Nem == "férfi").Average(l => l.Suly)} kg";
        }
    }
}