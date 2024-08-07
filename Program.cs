using System;
namespace CAULENHDIEUKIEN
{
    class TinhChiSoBMI
    {
        static void Main(string[] args)
        {
            float chieucao;
            float cannang;
            float bmi;

            Console.WriteLine("Nhap chieu cao (don vi met):");
            chieucao = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap can nang (don vi kilogam):");
            cannang = float.Parse(Console.ReadLine());

            bmi = cannang / (chieucao * chieucao);
            Console.WriteLine("Chi so BMI: " + bmi);
            if (bmi<18.5)
            {
                Console.WriteLine("Nhe can");
            }
            else if (bmi<25.0)
            {
                Console.WriteLine("Binh thuong");
            }
            else if (bmi<30.0)
            {
                Console.WriteLine("Thua can");
            }
            else Console.WriteLine ("Beo phi");
        }
    }
}

