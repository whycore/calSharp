using System;

namespace calculatorCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            static int Penambahan (int a, int b)
            {
                return a + b;
            }
            static int Pengurangan (int a, int b)
            {
                return a - b;
            }
            static int Pembagian (int a, int b)
            {
                return a / b;
            }
            static int Perkelian (int a, int b)
            {
                return a * b;
            }

            Console.Title = "APLIKASI KALKULATOR MANTAP";
            Console.Write("Masukan Nilai Pertama = ");
            var c = int.Parse(Console.ReadLine());

            Console.Write("Masukan Nilai Kedua = ");
            var d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Hasil Penambahannya adalah: {0} + {1} = {2}", c, d, Penambahan(c, d));
            Console.WriteLine("Hasil Pengurangannya adalah: {0} - {1} = {2}", c, d, Pengurangan(c, d));
            Console.WriteLine("Hasil Perkaliannya adalah: {0} * {1} = {2}", c, d, Perkelian(c, d));
            Console.WriteLine("Hasil Pembagiannya adalah: {0} / {1} = {2}", c, d, Pembagian(c, d));
            Console.ReadKey();
        }

    }
}
