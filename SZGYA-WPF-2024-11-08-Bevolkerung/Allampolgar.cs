using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung
{
    internal class Allampolgar
    {
        public int Id { get; set; }
        public string Nem { get; set; }
        public int SzuletesiEv { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }
        public bool_magyar Dohanyzik { get; set; }
        public string Nemzetiseg { get; set; }
        public string? Nepcsoport { get; set; }
        public string Tartomany { get; set; }
        public int NettoJovedelem { get; set; }
        public string? IskolaiVegzettseg { get; set; }
        public string PolitikaiNezet { get; set; }
        public bool_magyar AktivSzavazo { get; set; }
        public int? ItalFogyasztasEvente { get; set; }
        public int? KrumpliFogyasztasEvente { get; set; }

        public int Eletkor => DateTime.Now.Year - this.SzuletesiEv;
        public double HaviJovedelem => this.NettoJovedelem / 12;

        public Allampolgar(string sor)
        {
            string[] adatok = sor.Split(';');
            this.Id = int.Parse(adatok[0]);
            this.Nem = adatok[1];
            this.SzuletesiEv = int.Parse(adatok[2]);
            this.Suly = int.Parse(adatok[3]);
            this.Magassag = int.Parse(adatok[4]);
            this.Dohanyzik = adatok[5] == "igen";
            this.Nemzetiseg = adatok[6];
            this.Nepcsoport = adatok[7].Trim().Length != 0 ? adatok[7] : null;
            this.Tartomany = adatok[8];
            this.NettoJovedelem = int.Parse(adatok[9]);
            this.IskolaiVegzettseg = adatok[10].Trim().Length != 0 ? adatok[10] : null;
            this.PolitikaiNezet = adatok[11];
            this.AktivSzavazo = adatok[12] == "igen";
            this.ItalFogyasztasEvente = adatok[13] == "NA" ? null : int.Parse(adatok[13]);
            this.KrumpliFogyasztasEvente = adatok[14] == "NA" ? null : int.Parse(adatok[14]);
        }

        public override string ToString()
        {
            return $"{this.Id} {this.Nem} {this.SzuletesiEv} {this.Suly} {this.Magassag} {this.Dohanyzik} {this.Nemzetiseg} {this.Nepcsoport} {this.Tartomany} {this.NettoJovedelem} {this.IskolaiVegzettseg} {this.PolitikaiNezet} {this.AktivSzavazo} {this.ItalFogyasztasEvente} {this.KrumpliFogyasztasEvente}";
        }
        public string ToString(bool v)
        {
            if (v)
            {
                return $"{this.Id} {this.Nem} {this.SzuletesiEv} {this.Suly} {this.Magassag}";
            }
            else
            {
                return $"{this.Id} {this.Nemzetiseg} {this.Nepcsoport} {this.Tartomany} {this.NettoJovedelem}";
            }
        }
    }
}
