﻿using System;

namespace Zajecia_nr_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var reklama = new Reklama("Kup Teraz",
                                     GrupaWiekowa.Dorosli | GrupaWiekowa.Mlodziez,
                                     Zainteresowania.Komputery);

            for (int i = 0; i < GrupaWiekowa.Brak.SumaEnuma(); i++)
            {
                Console.WriteLine((GrupaWiekowa)i);
            }
        }
    }
}


//            // string napis;
//            //int wynik, reszta;
//            //  Console.Write("podaj napis - ");
//            //napis = Console.ReadLine();
//            //Console.WriteLine("Znak wystepuje = "+ napis.Zlicz_znaki('x'));
//            //int liczba = Convert.ToInt32(Console.ReadLine());
//            //(wynik,reszta)=liczba.DzielenieZReszta(3);
//            //Console.WriteLine($"{liczba}/3={wynik}r{reszta}");


//        }
//    }
//}

