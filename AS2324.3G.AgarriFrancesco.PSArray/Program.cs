using System;
using System.Xml.Schema;

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

            Console.WriteLine("questi voti sono in posizione dispari e maggiori di 4:");
            StampaVotiDispariMaggiori4(ref voti, ref pesi, nVoti);

            double max = 0;
            double min = 100;

            int posmax = 0;
            int posmin = 0;

            double mediaPonderata = MediaPonderata(voti, pesi, nVoti, ref max, ref posmax, ref min, ref posmin);
            Console.WriteLine($"questa e' la media ponderata: {mediaPonderata}");

            Console.WriteLine("questi sono i voti dopo la media:");
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

        static void StampaVotiDispariMaggiori4(ref double[] voti, ref int[] pesi, int nVoti)
        {
            for (int i = 0; i < nVoti; i++)
            {
                if (voti[i] > 4 && (i % 2 == 0 || i == 0))
                {
                    Console.Write(voti[i] + "\t");
                }
            }
        }

        static double MediaPonderata(double[] voti, int[] pesi, int nVoti, ref double max, ref int posmax, ref double min, ref int posmin)
        {
            double sommaVotiPesi = 0;
            int sommaPesi = 0;

            for (int i = 0; i < nVoti; i++)
            {
                sommaVotiPesi = voti[i] + pesi[i];
                sommaPesi += pesi[i];
            }

            double mediaPonderata = sommaVotiPesi / sommaPesi;

            max = 0;
            min = 100;

            posmax = 0;
            posmin = 0;


            for (int i = 0; i < nVoti; i++)
            {
                if (voti[i] > max)
                {
                    max = voti[i];
                    posmax = i + 1;
                }
                if (voti[i] < min)
                {
                    min = voti[i];
                    posmin = i + 1;
                }
            }

            return mediaPonderata;
        }


    }
}
