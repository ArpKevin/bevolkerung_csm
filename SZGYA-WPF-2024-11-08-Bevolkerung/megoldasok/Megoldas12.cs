using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas12 : Megoldas
    {
        public Megoldas12(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            return lakosok.Where(l => l.Nemzetiseg == "német")
                .GroupBy(x => x.Nepcsoport)
                .Select(x => $"{x.Key}\n {string.Join(' ', (x.Select(a => (a.AktivSzavazo ? $"\taktív szavazó {a.PolitikaiNezet}\n" : $"\tnem aktív szavazó {a.PolitikaiNezet}\n"))))}")
                .ToList();
        }
    }
}