using System;

namespace AS2324._3G.AgarriFrancesco.PSArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserire il numero di voti");
            int nVoti = Convert.ToInt32(Console.ReadLine());

            double[] voti = new double[nVoti];
            int[] pesi = new int[nVoti];

            CaricaVettori(ref voti, ref pesi, nVoti);

            Console.WriteLine("Primi voti caricati:");
            StampaVotiPesi(voti, pesi, nVoti);

            Console.ReadLine();
        }

        static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            Console.WriteLine("voti" + "\t" + "pesi");

            for (int i = 0; i < nVoti; i++)
            {
                Console.Write(voti[i] + "\t" + pesi[i] + "\n");
            }
        }

        static void CaricaVettori(ref double[] voti, ref int[] pesi, int nVoti)
        {
            Random random = new Random();

            for (int i = 0;i < nVoti; i++)
            {
                voti[i] = random.Next(1, 11);
                pesi[i] = random.Next(0, 101);
            }
        }

    }
}
