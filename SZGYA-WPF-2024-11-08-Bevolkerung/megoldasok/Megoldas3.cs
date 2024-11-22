using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas3 : Megoldas
    {
        public Megoldas3(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            return lakosok.GroupBy(l => l.Tartomany).Select(x => $"{x.Key} {x.Count()}").ToList();
        }
    }
}
