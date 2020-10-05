using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTProgammingTest.Models
{
    public static class CustomSort
    {
        //using QuickSort algorithim here 
        public static void SortListByValue(List<MainObject> mainObJects)
        {

            QuicksortValue(mainObJects, 0, mainObJects.Count - 1);

        }
        public static void SortListByLocation(List<MainObject> mainObJects)
        {

            QuicksortString(mainObJects, 0, mainObJects.Count - 1);

        }
       

        public static void QuicksortValue(List<MainObject> mainObJects, int left, int right)
        {
            int i = left;
            int j = right;

            int pivot = mainObJects[(left + right) / 2].Data.ElementAt(0).Value;

            while (i <= j)
            {
                while (mainObJects[i].Data.ElementAt(0).Value < pivot)
                    i++;

                while (mainObJects[j].Data.ElementAt(0).Value > pivot)
                    j--;

                if (i <= j)
                {
                    var tmp = mainObJects[i];
                    mainObJects[i] = mainObJects[j];
                    mainObJects[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
                QuicksortValue(mainObJects, left, j);

            if (i < right)
                QuicksortValue(mainObJects, i, right);
        }
        public static void QuicksortString(List<MainObject> mainObJects, int left, int right)
        {

            int i = left;
            int j = right;

            var pivot = mainObJects[(left + right) / 2].Data.ElementAt(0).Location;

            while (i <= j)
            {
                while (mainObJects[i].Data.ElementAt(0).Location.CompareTo(pivot) < 0)
                    i++;

                while (mainObJects[j].Data.ElementAt(0).Location.CompareTo(pivot) > 0)
                    j--;

                if (i <= j)
                {
                    var tmp = mainObJects[i];
                    mainObJects[i] = mainObJects[j];
                    mainObJects[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
                QuicksortString(mainObJects, left, j);

            if (i < right)
                QuicksortString(mainObJects, i, right);
        }



    }



}

