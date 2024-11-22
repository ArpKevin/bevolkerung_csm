using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas13 : Megoldas
    {
        public Megoldas13(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            return $"Éves átlagos sörfogyasztás a férfiak körében: {lakosok.Where(l => l.Nem == "férfi").Average(l => l.ItalFogyasztasEvente)} l";
        }
    }
}