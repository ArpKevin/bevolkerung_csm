//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Channels;
//using System.Threading.Tasks;

//namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
//{
//    internal class Megoldas42 : Megoldas
//    {
//        double atlagSorFogyasztas;
//        public Megoldas42(List<Allampolgar> lakosok) : base(lakosok)
//        {
//            atlagSorFogyasztas = lakosok.Average(l => l.ItalFogyasztasEvente).GetValueOrDefault();
//        }
//        public override List<string> ListaValasz()
//        {
//            Random r = new Random();
//        }
//    }
//}