using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas23 : Megoldas
    {
        public Megoldas23(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            var regioALegtobbLakossal = lakosok.Where(l => l.Nepcsoport != null)
            .GroupBy(l => l.Nepcsoport)
            .Select(l => new
            {
                Nepcsoport = l.Key,
                AtlagEletkor = l.Average(l => l.Eletkor),
                LakosokSzama = l.Count()
            })
            .OrderByDescending(g => g.LakosokSzama)
            .ThenByDescending(g => g.AtlagEletkor)
            .First();

            return $"A népcsoport a legtöbb lakossal: {regioALegtobbLakossal.Nepcsoport}, lakosai száma: {regioALegtobbLakossal.LakosokSzama}.";
        }
    }
}