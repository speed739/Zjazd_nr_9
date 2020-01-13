using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zajecia_nr_9
{
    static class Extenion_method
    {
        public static (int wynik, int reszta) DzielenieZReszta(this int liczba, int dzielnik)
        {

            return (liczba / dzielnik, liczba % dzielnik);
        }

        public static int Zlicz_znaki(this string napis, char znak)
        {
            int suma = 0;
            foreach (var item in napis)
            {
                if (item == znak)
                {
                    suma++;
                }
            }
            return suma;
        }

        public static int SumaGrupWiekowych(this GrupaWiekowa grupa)
        {

            return Enum.GetValues(typeof(GrupaWiekowa)).Cast<int>().Sum(x => (int)x);

            //int suma = 0;
            //foreach (var item in Enum.GetValues(typeof(GrupaWiekowa)))
            //{
            //    suma += (int)item;
            //}
            //return suma;

        }
        public static int SumaEnuma<T>(this T ele) where T : System.Enum
        {
            return Enum.GetValues(typeof(T))
                .Cast<int>()
                .Sum(x => (int)x);
        }

    }
}