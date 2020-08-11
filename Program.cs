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
            // 1-Leia dois arrays A e B com 15 elementos. Construir um array C, onde cada elemento de C
            // é a subtração do elemento correspondente de A com B.

            // teste ok

            int[] a = new int[15];
            int[] b = new int[15];
            int[] c = new int[15];
            int i = 0;

            for (i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine("Informe um valor inteiro para A:");

                while(true)
                {
                   try
                   {
                        a[i] = Convert.ToInt32(System.Console.ReadLine());
                        break;
                   }
                   catch (System.Exception)
                   {
                       Console.WriteLine("Valor inválido.");
                       Console.WriteLine("Informe um valor inteiro para A:");
                   }

                }
                
            }

            for (i = 0; i < b.Length; i++)
            {
                System.Console.WriteLine("Informe um valor inteiro para B:");

                while(true)
                {
                   try
                   {
                        b[i] = Convert.ToInt32(System.Console.ReadLine());
                        break;
                   }
                   catch (System.Exception)
                   {
                       Console.WriteLine("Valor inválido.");
                       Console.WriteLine("Informe um valor inteiro para B:");
                   }

                }

            }

            System.Console.WriteLine("Valor de C:");
            for (i = 0; i < c.Length; i++)
            {
                c[i] = a[i] - b[i];
                System.Console.WriteLine($"{c[i]}");
            }
        }

        static void Array2()
        {
            // 2-Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

            // teste ok

            int[] num = new int[10];
            var i = 0;

            for (i = 0; i < num.Length; i++)
            {
                System.Console.WriteLine("Informe um valor inteiro:");

                while(true)
                {
                   try
                   {
                        num[i] = Convert.ToInt32(System.Console.ReadLine());
                        break;
                   }
                   catch (System.Exception)
                   {
                       Console.WriteLine("Valor inválido.");
                       Console.WriteLine("Informe um valor inteiro:");
                   }

                }
                
            }

            System.Console.WriteLine("Lista inversa dos inteiros:");

            for (i = 9; i >= 0; i--)
            {
                System.Console.WriteLine($"{num[i]}");
            }
        }

        static void Array3()
        {
            // 3-Leia 10 elementos e armazene em um array A. Em seguida, solicite pelo teclado um
            // número qualquer e pesquise no array se o número existe. Caso, seja verdade imprima a
            // mensagem: “O número existe no array” , caso contrário “Número inexistente”.
                        
            
            // teste ok

            double[] a = new double[10];
            var i = 0;
            var existe = false;

            for (i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine("Informe um número:");

                while(true)
                {
                   try
                   {
                        a[i] = Convert.ToDouble(System.Console.ReadLine());
                        break;
                   }
                   catch (System.Exception)
                   {
                       Console.WriteLine("Valor inválido.");
                       Console.WriteLine("Informe um número:");
                   }

                }
                
            }

            System.Console.WriteLine("Informe um número a ser pesquisado:");
            var num = Convert.ToDouble(Console.ReadLine());

            foreach(var item in a)
            {
                if(item == num)
                {
                    existe = true;
                    break;
                }
            }

            var message = existe ? "O número existe no array." : "Número inexistente.";
            Console.WriteLine(message);

            // if (a.Contains(num))
            // {
            //     System.Console.WriteLine("O número existe no array.");
            // }
            // else
            // {
            //     System.Console.WriteLine("Número inexistente.");
            // }

        }

        static void Array4()
        {
            // 4-Leia dois arrays A e B com 10 elementos. Em seguida, compare os arrays e verifique se
            // os mesmos são iguais ou diferentes.
            
            // teste ok

            int[] a = new int[10];
            int[] b = new int[10];
            var i = 0;
            var counter = 0;

            for (i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine("Informe um valor inteiro para A:");

                while(true)
                {
                   try
                   {
                        a[i] = Convert.ToInt32(System.Console.ReadLine());
                        break;
                   }
                   catch (System.Exception)
                   {
                       Console.WriteLine("Valor inválido.");
                       Console.WriteLine("Informe um valor inteiro para A:");
                   }

                }
                
            }

            for (i = 0; i < b.Length; i++)
            {
                System.Console.WriteLine("Informe um valor inteiro para B:");

                while(true)
                {
                   try
                   {
                        b[i] = Convert.ToInt32(System.Console.ReadLine());
                        break;
                   }
                   catch (System.Exception)
                   {
                       Console.WriteLine("Valor inválido.");
                       Console.WriteLine("Informe um valor inteiro para B:");
                   }

                }

            }

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    counter++;
                }
            }

            var message = counter == a.Length ? "Os arrays são iguais." : "Os arrays são diferentes.";
            Console.WriteLine(message);


            // if (Enumerable.SequenceEqual(a, b))
            // {
            //     System.Console.WriteLine("Os arrays são iguais.");
            // }
            // else
            // {
            //     System.Console.WriteLine("Os arrays são diferentes.");
            // }

        }

        static void Array5()
        {
            // 5-Leia um array A com 15 elementos, e calcule a média aritmética dos mesmos, em
            // seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.
            
            // teste ok

            double[] a = new double [15];
            double soma = 0.0;
            var i = 0;
            double media;
            int counter = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;

            for (i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine("Informe um número:");
                a[i] = Convert.ToDouble(Console.ReadLine());
                soma += a[i];
                counter++;
            }

            media = soma / counter;

            for (i = 0; i < a.Length; i++)
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

           System.Console.WriteLine($"A média final é {media}.");
           System.Console.WriteLine($"{counter2} estão acima da média.");
           System.Console.WriteLine($"{counter3} estão na média.");
           System.Console.WriteLine($"{counter4} estão abaixo da média.");

        }

        static void Array6()
       {
            // teste executado
            int[] a = new int[3];
            int[] b = new int[3];
            int[] c = new int[3];
            var i = 0;

            for (i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine("Informe um número inteiro:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine("Ordem crescente de A:");
            var ordem = a.OrderBy(x => x);
            foreach (var item in ordem)
            {
                System.Console.WriteLine($"{item}");
            }

            for (i = 0; i < b.Length; i++)
            {
                System.Console.WriteLine("Informe um número inteiro:");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine("Ordem decrescente de B:");
            ordem = b.OrderByDescending(x => x);
            foreach (var item in ordem)
            {
                System.Console.WriteLine($"{item}");
            }
            
            for (i = 0; i < c.Length; i++)
            {
                c[i] = a[i] + b[i];
            }

            System.Console.WriteLine("Ordem crescente de C:");
            ordem = c.OrderBy(x => x);
            foreach (var item in ordem)
            {
                System.Console.WriteLine($"{item}");
            }
        } 

        static void Array1Lista2()   
        {
            // Popule dois vetores com 10 valores cada. Após esta operação, troque o conteúdo dos vetores.

            // teste ok

            int[] a = new int[10];
            var i = 0;

            for(i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Digite um número inteiro para A:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Array.Clear(a, 0, 10);
            
            for(i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Digite um novo número inteiro para A:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array A:");
            for(i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        static void Array2Lista2() 
        {
            // Dado um vetor qualquer com 10 números, faça um programa que informa se há ou não números repetidos nesse vetor.

            // teste ok
            
            int[] a = new int[3];
            int i = 0;

            for(i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Digite um número inteiro:");
                a[i] = Convert.ToInt32(Console.ReadLine());

            }

            var quantidadeRepetidos = a.Length - a.Distinct().Count();

            var message = quantidadeRepetidos > 0 ? "Sim, existem números repetidos." : "Não existem números repetidos.";
            Console.WriteLine(message);

        }

        static void Array3Lista2() 
        {
            // 3)Um certa empresa fez uma pesquisa para saber se as pessoas gostaram ou não de um novo
            // produto lançado no mercado. Para isso, forneceu-se o sexo do entrevistado e a sua resposta
            // (sim ou não). Sabendo-se que foram entrevistadas 10 pessoas, fazer um algoritmo que calcule e escreva:
            // • O número de pessoas que responderam sim;
            // • O número de pessoas que responderam não;
            // • A porcentagem de pessoas do sexo feminino que responderam sim;
            // • A porcentagem de pessoas do sexo masculino que responderam não;

            // teste ok
             
            string[] sex = new string[10];
            string[] answer = new string[10];
            var i = 0;
            var yes = 0;
            var no = 0;
            var femaleYes = 0.0;
            var maleNo = 0.0;

            for(i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe o sexo:");
                Console.WriteLine("[F] Feminino  [M] Masculino");
                sex[i] = Console.ReadLine();
                Console.WriteLine("Se você gostou do produto, digite [SIM]:");
                Console.WriteLine("Se você não gostou do produto, digite [NAO]:");
                answer[i] = Console.ReadLine();
                
                if (answer[i] == "SIM")
                {
                    yes++;
                }
                else
                {
                    no++;
                }

                if(sex[i] == "F" && answer[i] == "SIM")
                {
                    femaleYes++;
                }
                else if(sex[i] == "M" && answer[i] == "NAO")
                {
                    maleNo++;
                }
            }

            Console.WriteLine($"{yes} pessoas gostaram do produto.");
            Console.WriteLine($"{no} pessoas não gostaram do produto.");
            Console.WriteLine($"A porcentagem de pessoas do sexo feminino que respoderam positivamente foi de {(femaleYes / 10) * 100}%");
            Console.WriteLine($"A porcentagem de pessoas do sexo masculino que respoderam negativamente foi de {(maleNo / 10) * 100}%");
            
        }

        static void Array4Lista2() 
        {
            // 4)Desenvolver um programa que efetue a leitura de cinco elementos de uma matriz A do tipo vetor.
            // No final, apresente o total da soma de todos os elementos que sejam ímpares.

            // teste ok

            int[] a = new int[5];
            var i = 0;
            var soma = 0;

            for(i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Informe um número inteiro:");
                a[i] = Convert.ToInt32(Console.ReadLine());

                if(a[i] % 2 == 1)
                {
                    soma += a[i];
                }
            }

            Console.WriteLine($"A soma dos ímpares é {soma}");
        }

        static void Array5Lista2() 
        {
            // 5)Contar quantos valores de um vetor de 10 posições são positivos.

            // teste ok

            int[] a = new int[10];
            var i = 0;
            var count = 0;

            for(i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Informe um número inteiro:");
                a[i] = Convert.ToInt32(Console.ReadLine());

                if(a[i] > 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"O total de positivos é {count}");
        }

        static void Array6Lista2() 
        {
            // 6)Ler um vetor de 10 posições (aceitar somente números positivos). Escrever a seguir o
            // valor do maior elemento de Q e a respectiva posição que ele ocupa no vetor.

            // teste ok

            int[] q = new int[10];
            var i = 0;
            var maior = 0;
            var index = 0;

            for(i = 0; i < q.Length; i++)
            {
                Console.WriteLine("Informe um número inteiro positivo:");
                q[i] = Convert.ToInt32(Console.ReadLine());

                if(q[i] > maior)
                {
                    maior = q[i];
                    index = i;
                }
            }

            Console.WriteLine($"O maior elemento é o {maior}, e ocupa a posição {index} dentro do array.");
        }

        static void Array7Lista2() 
        {
            // 7)Crie e popule um vetor A e imprima na tela o número de vezes que existe um número
            // residindo na mesma posição do vetor que seu valor numérico.

            // teste ok

            int[] a = new int[10];
            var i = 0;
            var count = 0;

            for(i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Informe um número inteiro:");
                a[i] = Convert.ToInt32(Console.ReadLine());

                if(a[i] == i)
                {
                    count++;
                }
            }

            Console.WriteLine($"A quantidade de números iguais à sua posição é {count}");

        }

        static void Array8Lista2() 
        {
            // 8)Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto.
            // No final, imprima quantas destas são vogais.

            // teste ok

            string[] a = new string[10];
            var i = 0;
            var count = 0;

            for(i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Informe uma letra minúscula:");
                a[i] = Console.ReadLine();

                if(a[i] == "a" || a[i] == "e" || a[i] == "i" || a[i] == "o" || a[i] == "u")
                {
                    count++;
                }
            }

            Console.WriteLine($"O total de vogais é {count}");
        }

        static void Array9Lista2() 
        {
            // 9)Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto.
            // No final, imprima a string resultante da soma das strings que residem em índices pares.

            // teste ok

            string[] a = new string[10];
            var i = 0;

            for(i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Informe uma letra minúscula:");
                a[i] = Console.ReadLine();
            }

            Console.WriteLine($"String resultante: {a[2]}{a[4]}{a[6]}{a[8]}");
        }

        static void exemplos() 
        {
            // exemplo de Sort com Foreach
            
            int[] a = new int[12];
            var i = 0;

            for (i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine("Informe um número inteiro:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine("Ordem crescente de A:");
            Array.Sort(a);

            foreach(var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
