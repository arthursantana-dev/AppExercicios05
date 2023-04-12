using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicios05
{
    internal class Program
    {
        static void ExemploLaco()
        {
            int cont = 1;

            while (cont <= 10) {
                Console.WriteLine($"While: {cont}");
                cont++;
            }
        }

        static bool EhPrimo(int n)
        {
            if (n == 0 || n == 1) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0 && i != n && i != 1)
                {
                    return false;
                }
                
            }
            return true;

        }

        static void PrimosDeUmAN(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (EhPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void UmACem()
        {
            int n = 1;
            while (n <= 100)
            {
                Console.WriteLine(n);
                n++;
            }
        }

        static void CemAUm()
        {
            int n = 100;
            while (n >= 1) { 
                Console.WriteLine(n);
                n--;
            }
        }

        static void NumerosPares()
        {
            int n = 1;
            while (n <= 50) { 
                Console.WriteLine(n*2);
                n++;
            }
        }

        static void MultiplosDeNACem(int n)
        {
            int m = n;
            while (m <= 100)
            {
                Console.WriteLine(m);
                m += n;
            }
        }

        static void ParOuImparAteVinte()
        {
            Console.WriteLine("1 para ímpares. 2 para pares:");
            int i = int.Parse(Console.ReadLine());
            int passo = 2;

            while (i <= 20) {
                Console.WriteLine(i);
                i += passo;
            }
        }

        static void TabuadaDeN()
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;

            int m = int.Parse(Console.ReadLine());
            while (i <= m)
            {
                Console.WriteLine($"{i} x {n} = {i*n}");
                i++;
            }

        }
        static void Main(string[] args)
        {
            //ExemploLaco();

            //UmACem();
            //CemAUm();

            //NumerosPares();

            //PrimosDeUmAN(2000);

            //MultiplosDeNACem(8);

            //ParOuImparAteVinte();

            TabuadaDeN();

            Console.ReadKey();
        }
    }
}
