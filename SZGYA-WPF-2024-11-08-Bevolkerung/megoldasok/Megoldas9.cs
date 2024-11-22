using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas9 : Megoldas
    {
        public Megoldas9(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            return lakosok.Where(l => l.Nem == "nő" && l.Tartomany == "Bajorország").Select(x => x.ToString(false)).ToList();
        }
    }
}
