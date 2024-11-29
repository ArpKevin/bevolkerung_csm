using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas37 : Megoldas
    {
        double atlagNettoJovedelem;
        List<string> atlagonFeluliJovedelmezok;
        public Megoldas37(List<Allampolgar> lakosok) : base(lakosok)
        {
            atlagNettoJovedelem = lakosok.Average(l => l.NettoJovedelem);
            atlagonFeluliJovedelmezok = lakosok.Where(l => l.NettoJovedelem > atlagNettoJovedelem).Select(l => l.ToString(false)).ToList();
        }
        public override List<string> ListaValasz()
        {
            return atlagonFeluliJovedelmezok;
        }
        public override string MondatValasz()
        {
            return $"Átlag jövedelem: {atlagNettoJovedelem} év, átlagon felüli jövedelmezők darabszáma: {atlagonFeluliJovedelmezok.Count()} fő";
        }
    }
}