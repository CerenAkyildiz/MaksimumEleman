using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksimumEleman
{
    class Program
    {

        public static int MaxBul(int [] dizi )
        {
            int enbuyukEleman = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > enbuyukEleman)
                {
                    enbuyukEleman = dizi[i];
                }

            }
            return enbuyukEleman;
        }
        static void Main(string[] args)
        {

              int[] diziK = { 5, 3, 26, -1, 10, 25, 3, 4 };
     
            
         Console.WriteLine("En büyük eleman: "+MaxBul(diziK));

         Console.ReadLine();

        }
    }
}

   