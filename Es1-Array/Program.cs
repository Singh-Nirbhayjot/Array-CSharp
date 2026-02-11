using System;
using static System.Console;

namespace Es1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool d = true;
            do
            {
                WriteLine("Inserisci lunghezza del vettore");
            }
            while (!int.TryParse(ReadLine(), out n) || n <= 0);
 
            int[] v = new int[n];
            WriteLine("Inserisci valori");
            for(int i=0; i < v.Length; i++)
            {
                while (!int.TryParse(ReadLine(), out v[i]))
                {
                    WriteLine("Inserisci valore valido");
                }
            }
            for(int i=0; i < v.Length -1; i++)
            {
                for(int j=i+1; j < v.Length; j++)
                {
                    if (v[i] == v[j])
                    {
                        d = false;
                        break;
                    }
                    
                }
                if (!d)
                {
                    break;
                }
            }
            if (d)
            {
                Write(1);
            }
            else Write(0);

        }
    }
}