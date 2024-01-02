using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachOrnek202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] B = new int[5];
            int a = 0, say = 0, toplam = 0;

            foreach (int al in B)
            {
                Console.Write(a + ". Elemanı Gir: ");
                B[a] = Int32.Parse(Console.ReadLine());
                if (B[a] % 10 == 0)
                {
                    say++;
                    toplam += B[a];

                }
                a++;
            }

            double ortalama = 0;

            if (say > 0)
            {
                ortalama = (double)toplam / say;
            }

            Console.WriteLine("Son Rakamı Sıfır Olan Sayı Adedi: " + say);
            Console.WriteLine("Girdiğiniz sayıların ortalaması:" + ortalama);
            Console.WriteLine("Girdiğiniz sayıların toplamı:" + toplam);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}