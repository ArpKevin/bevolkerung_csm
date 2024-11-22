using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas24 : Megoldas
    {
        public Megoldas24(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            var dohanyzokAtlagfizetese = lakosok.Where(l => l.Dohanyzik).Average(l => l.NettoJovedelem);
            var nemDohanyzokAtlagfizetese = lakosok.Where(l => !l.Dohanyzik).Average(l => l.NettoJovedelem);
            return $"Dohányzók jövedelme: {dohanyzokAtlagfizetese}, nemdohányzók jövedelme: {nemDohanyzokAtlagfizetese}. A magasabb átlagos jövedelmű csoport: {(dohanyzokAtlagfizetese > nemDohanyzokAtlagfizetese ? "Dohányzók" : "Nem dohányzók")}.";
        }
    }
}