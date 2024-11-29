using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas44 : Megoldas
    {
        List<Allampolgar> ismeretlenIskolaiVegzettsegu;
        public Megoldas44(List<Allampolgar> lakosok) : base(lakosok)
        {
            ismeretlenIskolaiVegzettsegu = lakosok.Where(l => l.IskolaiVegzettseg == null).ToList();
        }
        public override List<Allampolgar> GridValasz()
        {
            Random r = new Random();
            HashSet<Allampolgar> randomLista = new();
            if (ismeretlenIskolaiVegzettsegu.Count() >= 3) while (randomLista.Count < 3) randomLista.Add(ismeretlenIskolaiVegzettsegu[r.Next(ismeretlenIskolaiVegzettsegu.Count())]);
            return randomLista.ToList();
        }
        public override string MondatValasz()
        {
            return (ismeretlenIskolaiVegzettsegu.Count() < 3) ? "Nincsen megfelelő mennyiségű ismeretlen végzettségű lakos." : "";
        }
    }
}