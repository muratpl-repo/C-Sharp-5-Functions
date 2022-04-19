using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42DersMethotlar_Fonksiyonlar_
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 5;
            int sayi2 = 10;
            topla(sayi1, sayi2);
            Console.WriteLine(buyukMu((9.4), (8.7)));
        }

        //BOS DONDUREN METHOTLAR (VOID)
        static void topla(int sayi1,int sayi2)
        {
            Console.WriteLine("Sayilarin toplami: " + (sayi1 + sayi2));
        }

        //DONUS DEGERINE SAHIP METHOTLAR (INT, FLOAT, DOUBLE, BOOL ETC.)
        static double buyukMu(double sayi3, double sayi4)
        //static double buyukMu(double sayi3 = 0, double sayi4 = 0) *** Sabit olarak 0 degerlerini atayabiliyoruz...
        {
            if (sayi3 > sayi4)
            {
                return sayi3;
            }
            else
            {
                return sayi4;
            }
        }


    }
}
