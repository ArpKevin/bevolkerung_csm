using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas19 : Megoldas
    {
        public Megoldas19(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            var legmagasabbNettoJovedelmmelRendelkezoRegio = lakosok
            .GroupBy(l => l.Tartomany)
            .Select(l => new
            {
                Regio = l.Key,
                AtlagFizetes = l.Average(l => l.NettoJovedelem),
                LakosokSzama = l.Count()
            })
            .OrderByDescending(g => g.AtlagFizetes)
            .ThenByDescending(g => g.LakosokSzama)
            .First();

            return $"A legmagasabb nettó jövedelemmel rendelkező régió neve: {legmagasabbNettoJovedelmmelRendelkezoRegio.Regio}, az átlagos nettó jövedelem: {legmagasabbNettoJovedelmmelRendelkezoRegio.AtlagFizetes}, a lakosok száma: {legmagasabbNettoJovedelmmelRendelkezoRegio.LakosokSzama}";


        }
    }
}