using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas22 : Megoldas
    {
        public Megoldas22(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            return $"Férfiak átlagmagassága: {lakosok.Where(l => l.Nem == "férfi").Average(l => l.Magassag)}, nők átlagmagassága: {lakosok.Where(l => l.Nem == "nő").Average(l => l.Magassag)}";
        }
    }
}