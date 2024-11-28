using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas28 : Megoldas
    {
        public List<Allampolgar> dohanyzoNok;
        public Megoldas28(List<Allampolgar> lakosok) : base(lakosok)
        {
           dohanyzoNok = lakosok.Where(l => l.Dohanyzik && l.Nem == "nő").ToList();
        }
        public override List<string> ListaValasz()
        {
            return dohanyzoNok.Select(l => l.ToString(false)).ToList();
        }
        public override string MondatValasz()
        {
            if (dohanyzoNok.Count() == 0)
            {
                return $"Nem található dohányzó nő.";
            }
            else
            {
                return $"A legnagyobb nettó jövedelem dohányző nők körében: {dohanyzoNok.Max(d => d.NettoJovedelem)} EUR";
            }
        }
    }
}