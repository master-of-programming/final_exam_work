using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İlk matrisin satır sayısını girin : ");
            int masat = Convert.ToInt32(Console.ReadLine());
            Console.Write("İlk matrisin sütun sayısını girin : ");
            int masut = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci matrisin satır sayısını girin : ");
            int mbsat = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci matrisin sütun sayısını girin : ");
            int mbsut = Convert.ToInt32(Console.ReadLine());
            int[,] matrisA = new int[masat, masut];
            int[,] matrisB = new int[mbsat, mbsut];
            Random rnd = new Random();
            Console.WriteLine("**************İLK MATRİS*****************");
            for (int i = 0; i < masat; i++)
            {
                for (int j = 0; j < masut; j++)
                {
                    matrisA[i,j]=rnd.Next(0,12);
                    Console.Write(matrisA[i, j]+"\t" );
                }
                Console.WriteLine();
            }
            Console.WriteLine("********İKİNCİ MATRİS****************");
            for (int k = 0; k < mbsat; k++)
            {
                for (int l = 0; l < mbsut; l++)
                {
                    matrisB[k,l] = rnd.Next(0, 12);
                    Console.Write(matrisB[k,l] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("**************SKALER ÇARPIMI***********************");
            int[,] matrisC = new int[matrisA.GetUpperBound(0) + 1, matrisB.GetUpperBound(1) + 1];
            for (int a = 0; a <=matrisA.GetUpperBound(0); a++)
            {
                for (int b = 0; b <= matrisB.GetUpperBound(1); b++)
                {
                    int toplam =0;
                    for (int c = 0; c <=matrisA.GetUpperBound(1); c++)
                    {
                        toplam += matrisA[a, c] * matrisB[c, b];
                    }
                    matrisC[a, b] = toplam;
                    Console.Write(matrisC[a, b] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey(); 
        }
    }
}
