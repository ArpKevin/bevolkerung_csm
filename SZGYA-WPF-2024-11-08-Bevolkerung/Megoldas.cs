    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace SZGYA_WPF_2024_11_08_Bevolkerung
    {
        internal class Megoldas
        {
            protected List<Allampolgar> lakosok;
            public Megoldas(List<Allampolgar> lakosok) 
            {
                this.lakosok = lakosok;
            }

            public virtual string MondatValasz()
            {
                return "";
            }

            public virtual List<string> ListaValasz()
            {
                return new List<string>();
            }

            public virtual List<Allampolgar> GridValasz() 
            {
                return new List<Allampolgar>();
            }
        }
    }
