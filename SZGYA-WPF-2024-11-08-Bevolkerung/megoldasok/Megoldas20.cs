using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas20 : Megoldas
    {
        public Megoldas20(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            var lakossagiSulyok = lakosok.Select(l => l.Suly).ToList();
            var atlagSuly = lakossagiSulyok.Average();
            var medianSuly = findMedian(lakossagiSulyok);

            return $"Az átlagsúly {atlagSuly} kg, míg a medián súly {medianSuly} kg.";
        }

        public static int findMedian(List<int> arr)
        {
            arr.Sort();
            int mid = arr.Count / 2;
            int median = 0;
            if (mid % 2 != 0)
            {
                median = arr[mid];
            }
            else
            {
                median = (arr[mid - 1] + arr[mid]) / 2;
            }

            return median;
        }

    }
}