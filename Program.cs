using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20242452010_Yigitogan_mbp193_proje
{
    internal class Program
    {
        static void Main()
        {

            giris();
            string ad = ilkDeger();
            string tcKimlik = tcOlustur();
            cikti(ad, tcKimlik);
        }

        static void giris()
        {

            Console.WriteLine("TC Kimlik Numarası Oluşturma Sistemi");

        }


        static string ilkDeger()
        {
            Console.Write("Adınızı Giriniz: ");
            string ad = Console.ReadLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"\nMerhaba {ad.ToUpper()},TC Kimlik Numarası Oluşturma Sistemimize Hoş Geldiniz.");
            return ad;
        }


        static string tcOlustur()
        {
            Random random = new Random();
            int[] tcKimlikDizisi = new int[11];


            tcKimlikDizisi[0] = random.Next(1, 10);
            for (int i = 1; i < 9; i++)
            {
                tcKimlikDizisi[i] = random.Next(0, 10);
            }


            int tekToplam = 0, ciftToplam = 0;
            for (int i = 0; i < 9; i += 2)
            {
                tekToplam += tcKimlikDizisi[i];
            }
            for (int i = 1; i < 8; i += 2)
            {
                ciftToplam += tcKimlikDizisi[i];
            }
            tcKimlikDizisi[9] = ((tekToplam * 7) - ciftToplam) % 10;
            if (tcKimlikDizisi[9] < 0)
            {
                tcKimlikDizisi[9] += 10;
            }

            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                toplam += tcKimlikDizisi[i];
            }
            tcKimlikDizisi[10] = toplam % 10;


            string tcKimlik = string.Join("", tcKimlikDizisi);
            return tcKimlik;
        }


        static void cikti(string ad, string tcKimlik)
        {
            Console.WriteLine("\nTC Kimlik Numaranız oluşturuluyor...");
            Thread.Sleep(5000);
            Console.WriteLine(tcKimlik);
            Console.ReadKey();




        }










    }
}
