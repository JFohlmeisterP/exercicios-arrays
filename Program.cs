using System;
using System.Linq;

namespace exercicios_arrays
{
    class Program
    {
        static void Main(string[] args)
        {              
            Array2Lista2();
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
            }

            System.Console.WriteLine("Valor de C:");
            for (i = 0; i < 15; i++)
            {
                c[i] = a[i] - b[i];
                System.Console.WriteLine($"{c[i]}");
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
            // teste executado
            int[] a = new int[10];
            int[] b = new int[10];
            var i = 0;

            for (i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Informe um número inteiro para A:");
                a[i] = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Informe um número inteiro para B:");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (Enumerable.SequenceEqual(a, b))
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

        static void Array1Lista2()   
        {
            // Popule dois vetores com 10 valores cada. Após esta operação, troque o conteúdo dos vetores.
            // teste ok

            int[] a = new int[10];
            var counter = 0;
            var counter2 = 0;
            var counter3 = 0;

            while(counter < 10)
            {
                Console.WriteLine("Digite um número inteiro:");
                a[counter] = Convert.ToInt32(Console.ReadLine());
                counter++;
            }
            
            Array.Clear(a, 0, 10);
            
            while(counter2 < 10)
            {
                Console.WriteLine("Digite um número inteiro:");
                a[counter2] = Convert.ToInt32(Console.ReadLine());
                counter2++;
            }

            Console.WriteLine("Array A:");
            while(counter3 < 10)
            {
                Console.WriteLine(a[counter3]);
                counter3++;
            }
        }

        static void Array2Lista2() 
        {
            // Dado um vetor qualquer com 10 números, faça um programa que informa se há ou não números repetidos nesse vetor.
            int[] a = new int[10];
            int i = 0;

            for(i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número inteiro:");
                a[i] = Convert.ToInt32(Console.ReadLine());

            }

        }

        static void Array3Lista2() 
        {
            //3)Um certa empresa fez uma pesquisa para saber se as pessoas gostaram ou não de um novo
            // produto lançado no mercado. Para isso, forneceu-se o sexo do entrevistado e a sua resposta
            // (sim ou não). Sabendo-se que foram entrevistadas 10 pessoas, fazer um algoritmo que calcule e escreva:
            // • O número de pessoas que responderam sim;
            // • O número de pessoas que responderam não;
            // • A porcentagem de pessoas do sexo feminino que responderam sim;
            // • A porcentagem de pessoas do sexo masculino que responderam não; 
            string[] name = new string[10];
            string[] answer = new string[10];
            var i = 0;
            var yescounter = 0;
            var nocounter = 0;

            for(i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe seu nome:");
                name[i] = Console.ReadLine();
                Console.WriteLine("Se você gostou do produto, digite (sim):");
                Console.WriteLine("Se você não gostou do produto, digite (nao):");
                answer[i] = Console.ReadLine();
                
                if ()
            }

            
        }

        static void Array4Lista2() 
        {
            // 4)Desenvolver um programa que efetue a leitura de cinco elementos de uma matriz // A do tipo vetor.
            // No final, apresente o total da soma de todos os elementos que sejam impares.
        }

        static void Array5Lista2() 
        {
            // 5)Contar quantos valores de um vetor de 10 posições são positivos.
        }

        static void Array6Lista2() 
        {
            // 6)Ler um vetor de 10 posições (aceitar somente números positivos). Escrever a seguir o
            // valor do maior elemento de Q e a respectiva posição que ele ocupa no vetor.
        }

        static void Array7Lista2() 
        {
            // 7)Crie e popule um vetor A e imprima na tela o número de vezes que existe um número
            // residindo na mesma posição do vetor que seu valor numérico.
        }

        static void Array8Lista2() 
        {
            // 8)Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto.
            // No final, imprima quantas destas são vogais.
        }

        static void Array9Lista2() 
        {
            // 9)Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto.
            // No final, imprima a string resultante da soma das strings que residem em índices pares.
        }
    }
}
