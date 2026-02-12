using System;
using static System.Console;

namespace Es3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] v = new int[100];
            int s = 0;

            for (int i = 0; i < v.Length && s < 50; i++)
            {
                do
                {
                    WriteLine("Inserisci numero ");
                } while (!int.TryParse(ReadLine(), out v[i]));

                s += v[i];
            }

            bool r = false;

            for (int i = 0; i < v.Length; i++)
            {
                for (int j = i + 1; j < v.Length; j++)
                {
                    if ((v[j] != 0 && v[i] / v[j] == v[0]) || (v[i] != 0 && v[j] / v[i] == v[0]))
                    {
                        WriteLine("Il rapporto tra " + v[i] + " e " + v[j] + " è uguale a " + v[0]);
                        r = true;
                        break;
                    }
                }

                if (r)
                {
                    break;
                }
            }
            if (!r)
                Console.WriteLine("Non esiste coppia");
        }
    }
}

