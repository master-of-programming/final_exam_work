using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            AnaSınıf anaSınıf = new AnaSınıf();
            anaSınıf.AnaMetod();
            Console.ReadKey();
        }
    }
    public class DikÜçgen{
       public  int akenar, bkenar;
        double hipo;
        public void Alan(int a, int b) {
            a = akenar;b = bkenar;
            double alan = (a * b)/ 2;
            Console.WriteLine("Alanı : " + alan);
        }
        public void Cevre(int a, int b) {
            Hipo(a,b);
            double cevre = a + b + hipo;
            Console.WriteLine("Çevresi : " + cevre);
        }
        public void Hipo(int a, int b) {
            hipo = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Hipotenüs : " + hipo);
        }
        public void Yaz() {
            Console.WriteLine("A kenarı : "+akenar);
            Console.WriteLine("B kenarı : "+bkenar);
            Alan(akenar,bkenar);
            Cevre(akenar, bkenar);
        }
    }
    public class AnaSınıf
    {
        public void AnaMetod()
        {
            DikÜçgen dik = new DikÜçgen();
            dik.akenar = 30;
            dik.bkenar = 40;
            dik.Yaz();
        }
    }
}
