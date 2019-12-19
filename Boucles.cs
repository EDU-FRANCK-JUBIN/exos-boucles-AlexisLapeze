using System;
using System.Collections.Generic;

namespace test
{
    public class Boucles
    {
        public Boucles()
        {

        }

        public static void Entre()
        {
            for (int i = 0; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.Out.Write("saisissez un nombre : ");
            int n = 0;
            string val;
            val = Console.ReadLine();
            n = Convert.ToInt32(val);
            int value = 0;
            for (int i = 1; i <= n; i++)
            {
                value = value + i;
            }
            Console.WriteLine("value = " + value);


            Console.Out.Write("saisissez un nombre : ");
            int n1 = 0;
            val = Console.ReadLine();
            n1 = Convert.ToInt32(val);
            Console.Out.Write("saisissez un nombre de plus : ");
            int n2 = 0;
            val = Console.ReadLine();
            n2 = Convert.ToInt32(val);
            Console.Out.Write("saisissez un nombre de plus : ");
            int n3 = 0;
            val = Console.ReadLine();
            n3 = Convert.ToInt32(val);
            Console.Out.Write("saisissez un nombre de plus : ");
            int n4 = 0;
            val = Console.ReadLine();
            n4 = Convert.ToInt32(val);
            Console.Out.Write("saisissez un nombre de plus : ");
            int n5 = 0;
            val = Console.ReadLine();
            n5 = Convert.ToInt32(val);

            double moy = (n1 + n2 + n3 + n4 + n5) / 5;
            Console.WriteLine("Moyenne : " + moy);

            Console.WriteLine(calculSommeEntier(1, 10));
            List<double> l = new List<double>();
            l.Add(1.0);
            l.Add(5.5);
            l.Add(9.9);
            l.Add(2.8);
            l.Add(9.6);

            Console.WriteLine(calculMoyenneListe(l));

            List<int> multipleTrois = new List<int>();
            for (int i = 3; i <= 100; i += 3)
            {
                //Console.WriteLine(i);
                multipleTrois.Add(i);
            }

            List<int> multipleCinq = new List<int>();
            for (int i = 5; i <= 100; i += 5)
            {
                //Console.WriteLine(i);
                multipleCinq.Add(i);
            }
            int sum = 0;
            foreach (int mtrois in multipleTrois)
            {
                foreach (int mcinq in multipleCinq)
                {
                    if (mtrois == mcinq)
                    {
                        sum += (mtrois + mcinq);
                    }
                }
            }
            Console.WriteLine(sum);
        }

        public static double calculSommeEntier(double x, double y)
        {
            double sum = 0;
            for (double i = x; i <= y; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static double calculMoyenneListe(List<double> l)
        {
            double sum = 0;
            foreach (double i in l)
            {
                sum += i;
            }
            return sum / l.Count;
        }

    }
}
