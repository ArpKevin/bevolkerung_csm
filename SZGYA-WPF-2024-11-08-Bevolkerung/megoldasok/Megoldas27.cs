using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas27 : Megoldas
    {
        public Megoldas27(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            var _50evFelettiek = lakosok.Where(l => l.Eletkor > 50).ToList();

            var formattedStringList = new List<string>
            {
                $"50 év felettiek száma: {_50evFelettiek.Count()}"
            };

            formattedStringList.AddRange(_50evFelettiek.Select(l => l.ToString(true)));

            return formattedStringList;

        }
    }
}