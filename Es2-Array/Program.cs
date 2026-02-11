using System;
using static System.Console;

namespace Es2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[30];
            Random rnd = new Random();

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(0, 101);
                Write(v[i] + " ");
            }
            Write("\n");
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] % 2 == 0)
                {
                    for (int j = 0; j < v.Length; j++)
                    {
                        if (v[i] == 2 * v[j])
                        {
                            WriteLine( v[i] + " " + v[j]);
                        }
                    }
                }

            }
        }
    }
}
