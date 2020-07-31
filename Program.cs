using System;
using System.Linq;

namespace exercicios_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Array1()
        {
            // teste executado
            int[] a = new int[15];
            int[] b = new int[15];
            int[] c = new int[15];
            int i = 0;

            for (i = 0; i < 15; i++)
            {
                System.Console.WriteLine("Informe um valor para A:");
                a[i] = Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Informe um valor para B:");
                b[i] = Convert.ToInt32(System.Console.ReadLine());
                c[i] = a[i] - b[i];
                System.Console.WriteLine($"Valor de C: {c[i]}");
            }
        }

        static void Array2()
        {
            // teste executado
            int[] num = new int[10];
            var i = 0;

            for (i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Informe um número inteiro:");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine("Lista decrescente dos inteiros:");

            for (i = 9; i >= 0; i--)
            {
                System.Console.WriteLine($"{num[i]}");
            }
        }

        static void Array3()
        {
            // teste executado
            int[] a = new int[10];
            var i = 0;

            for (i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Informe um número inteiro:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine("Informe um número inteiro a ser pesquisado:");
            var num = Convert.ToInt32(Console.ReadLine());

            if (a.Contains(num))
            {
                System.Console.WriteLine("O número existe no array.");
            }
            else
            {
                System.Console.WriteLine("Número inexistente.");
            }

        }

        static void Array4()
        {
            // pesquisar comparação
            int[] a = new int[10];
            int[] b = new int[10];
            var i = 0;

            for (i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Informe um número inteiro:");
                a[i] = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Informe um número inteiro:");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (a[10] == b[10])
            {
                System.Console.WriteLine("Os arrays são iguais.");
            }
            else
            {
                System.Console.WriteLine("Os arrays são diferentes.");
            }

        }

        static void Array5()
        {
            // teste executado
            int[] a = new int [15];
            var soma = 0;
            var i = 0;
            var media = 0;
            var counter = 0;
            var counter2 = 0;
            var counter3 = 0;
            var counter4 = 0;

            for (i = 0; i < 15; i++)
            {
                System.Console.WriteLine("Informe um número inteiro:");
                a[i] = Convert.ToInt32(Console.ReadLine());
                soma = soma + a[i];
                counter++;
            }

            media = soma / counter;

            for (i = 0; i < 15; i++)
            {
                if (a[i] > media)
                {
                    counter2++;
                }
                else if (a[i] == media)
                {
                    counter3++;
                }
                else
                {
                    counter4++;
                }
            }

           System.Console.WriteLine($"A média final é {counter2}.");
           System.Console.WriteLine($"{counter2} estão acima da média.");
           System.Console.WriteLine($"{counter3} estão na média.");
           System.Console.WriteLine($"{counter4} estão abaixo da média.");

        }

        static void Array6()
       {
            // teste executado
            int[] a = new int[12];
            int[] b = new int[12];
            int[] c = new int[12];
            var i = 0;

            for (i = 0; i < 12; i++)
            {
                System.Console.WriteLine("Informe um número inteiro:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine("Ordem crescente de A:");
            var temp = a.ToList().OrderBy(x => x);
            foreach (var elemento in temp)
            {
                System.Console.WriteLine($"{elemento}");
            }

            for (i = 0; i < 12; i++)
            {
                System.Console.WriteLine("Informe um número inteiro:");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine("Ordem decrescente de B:");
            temp = b.ToList().OrderByDescending(x => x);
            foreach (var elemento in temp)
            {
                System.Console.WriteLine($"{elemento}");
            }
            
            for (i = 0; i < 12; i++)
            {
                c[i] = a[i] + b[i];
            }

            System.Console.WriteLine("Ordem crescente de C:");
            temp = c.ToList().OrderBy(x => x);
            foreach (var elemento in temp)
            {
                System.Console.WriteLine($"{elemento}");
            }
       }
    }
}
