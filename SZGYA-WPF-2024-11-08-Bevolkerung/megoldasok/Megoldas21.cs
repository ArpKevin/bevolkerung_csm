using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas21 : Megoldas
    {
        public Megoldas21(List<Allampolgar> lakosok) : base(lakosok)
        { }
        //public override string MondatValasz()
        //{
        //    var aktivSzavazokSorfogyasztasa = lakosok.Where(l => l.AktivSzavazo).Sum(l => l.ItalFogyasztasEvente);
        //}

    }
}