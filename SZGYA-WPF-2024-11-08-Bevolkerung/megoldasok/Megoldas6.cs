using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas6 : Megoldas
    {
        public Megoldas6(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            return lakosok.Where(l => l.Dohanyzik).Select(x=> $"{x.Id} {x.HaviJovedelem}").ToList();
        }
    }
}
