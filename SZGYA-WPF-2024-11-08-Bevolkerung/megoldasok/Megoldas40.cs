using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas40 : Megoldas
    {
        public Megoldas40(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            var nemetekAtlagJovedelme = lakosok.Where(l => l.Nemzetiseg == "német").Average(l => l.NettoJovedelem);
            var nemNemetekAtlagJovedelme = lakosok.Where(l => !(l.Nemzetiseg == "német")).Average(l => l.NettoJovedelem);
            return $"A németek és nem németek havi jövedelmének százalékos aránya: {nemetekAtlagJovedelme / nemNemetekAtlagJovedelme * 100}%";
        }
    }
}