using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas33 : Megoldas
    {
        public Megoldas33(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            return lakosok.OrderByDescending(l => l.NettoJovedelem).Take(3).Select(l => $"{l.Id} {l.NettoJovedelem}").ToList();
        }
    }
}