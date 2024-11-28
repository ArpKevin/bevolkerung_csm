using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas29 : Megoldas
    {
        public Megoldas29(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            return lakosok
                .GroupBy(l => l.Tartomany)
                .Select(x => new
                {
                    TartomanyNev = x.Key,
                    Lakos = x.OrderByDescending(y => y.ItalFogyasztasEvente).FirstOrDefault()
                })
                .Select(x => $"Tartomány: {x.TartomanyNev}, lakos id: {x.Lakos.Id}, Sörfogyasztás: {x.Lakos.ItalFogyasztasEvente} liter").ToList();
        }
    }
}