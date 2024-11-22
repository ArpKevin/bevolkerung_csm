using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas2 : Megoldas
    {
        public Megoldas2(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            return $"Az állampolgárok átlagos nettó éves jövedelme {Math.Round(lakosok.Average(l => l.NettoJovedelem), 2)} EUR";
        }
    }
}
