// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PenghitungVolumeTabung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pendeklarasian Variabel
            /*
            phi variabel dari 3.14 atau 22/7
            r variabel dari jari-jari alas tabung
            t variabel dari tinggi tabung
            v variabel dari volume
            */
            double phi, r, t, v;
            phi = 3.14;
            char u;

            do
            {
                Console.Clear();
                //Judul Program
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ===================================================================");
                Console.WriteLine(" ||               PROGRAM PENGHITUNG VOLUME TABUNG                ||");
                Console.WriteLine(" ===================================================================");
                Console.WriteLine(" =                                                                 =");
                Console.WriteLine(" ===================================================================");
                Console.WriteLine(" ||                          Created By:                          ||");
                Console.WriteLine(" ||                 https://idekevin.blogspot.com                 ||");
                Console.WriteLine(" ===================================================================");
                Console.WriteLine(" =                                                                 =");
                Console.WriteLine(" ===================================================================");
                Console.WriteLine(" ||                       CARA MENGGUNAKAN :                      ||");
                Console.WriteLine(" ||             Tekan enter, setelah memasukkan input!            ||");
                Console.WriteLine(" ===================================================================");
                Console.WriteLine();
                Console.WriteLine(" ___________________________________________________________________");
                Console.WriteLine();
                Console.WriteLine();

                //Program Penghitung Volume Tabung
                Console.Write(" Silahkan masukkan jari-jari (r) alas (cm): ");
                r = double.Parse(Console.ReadLine());
                Console.Write("  Silahkan masukkan tinggi (t) tabung (cm): ");
                t = double.Parse(Console.ReadLine());
                v = (3.14) * r * r * t;
                Console.WriteLine("     Hasilnya, besar volume tabung adalah : {0} cm", v);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" Penjelasan :");
                Console.WriteLine();
                Console.WriteLine(" Rumus Volume Tabung adalah V = Phi . r² . t");
                Console.WriteLine(" Di mana, r = jari-jari alas tabung, dan");
                Console.WriteLine("          t = tinggi tabung");
                Console.WriteLine();
                Console.WriteLine(" Kita ketahui bahwasannya :");
                Console.WriteLine("          r = {0} cm", r);
                Console.WriteLine("          t = {0} cm", t);
                Console.WriteLine();
                Console.WriteLine(" Sehingga kita bisa mensubstitusikan ke dalam rumus sebagai berikut :");
                Console.WriteLine("          V = Phi . r² . t");
                Console.WriteLine("            = {0} . {1}² . {2}", phi, r, t);
                Console.WriteLine();
                Console.WriteLine(" Jadi, volume bola adalah {0} cm", v);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" Ingin Menghitung Lagi? (y/t)");
                Console.Write(" Jawab : ");
                u = char.Parse(Console.ReadLine());
            }
            while (u == 'y' | u == 'Y');

            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" TIPS :");
                Console.WriteLine(" Berlatih soal-soal secara rutin, akan membantumu");
                Console.WriteLine(" mengusai Matematika.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------- Selamat Belajar! ------------------------");
                Console.WriteLine(" -------------------- Matematika itu Menyenangkan ------------------");
                Console.WriteLine(" - Jangan mudah menyerah, karena usaha tidak akan menghianati hasil-");
                Console.ReadLine();
                Console.Clear();
            }
            while (u == 't' | u == 'T');
            Console.ReadLine();
            Console.Clear();
        }
    }
}