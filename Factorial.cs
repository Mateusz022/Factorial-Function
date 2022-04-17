using System;

namespace silnia_rekurencyjnieeeee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba = 4;
            Console.WriteLine("Silnia dla " + liczba + " to: ");
            Console.WriteLine(wyliczSilnie(liczba));
            Console.ReadKey();
        }
        static int wyliczSilnie(int n)
            {
                if (n <= 1) return 1;
                else return n * wyliczSilnie(n - 1);
            }

        }
    }
            // Bez rekurencji
        static int Silnia(int n)
        {
    int s = 1;
    for (int i = 1; i <= n; i++)
        s = s * i;
    return (s);
        }
        // Z rekurencją
        static int Silnia(int n)
        {
    if (n <= 1)
        return 1;
    else
        return n * Silnia(n - 1);
        }

