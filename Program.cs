using System;
using System.Linq;

namespace exercicios_arrays
{
    class Program
    {
        static void Main(string[] args)
        {              
            questão6();
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

                while(true)
                {
                    Console.WriteLine("Informe um valor inteiro para A:");

                   try
                   {
                        a[i] = Convert.ToInt32(System.Console.ReadLine());
                        break;
                   }
                   catch (System.Exception)
                   {
                       Console.WriteLine("Valor inválido.");
                   }

                }
                
            }

            for (i = 0; i < b.Length; i++)
            {

                while(true)
                {
                    Console.WriteLine("Informe um valor inteiro para B:");

                   try
                   {
                        b[i] = Convert.ToInt32(System.Console.ReadLine());
                        break;
                   }
                   catch (System.Exception)
                   {
                       Console.WriteLine("Valor inválido.");
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

            int[] a = new int[3];
            int?[] b = new int?[3];
            var equal = true;

            for (var i = 0; i < a.Length; i++)
            {

                while(true)
                {
                    System.Console.WriteLine("Informe um valor inteiro para A:");

                   try
                   {
                        a[i] = Convert.ToInt32(System.Console.ReadLine());
                        break;
                   }
                   catch (System.Exception)
                   {
                       Console.WriteLine("Valor inválido.");
                   }

                }
                
            }

            for (var i = 0; i < b.Length; i++)
            {
                
                while(true)
                {
                    System.Console.WriteLine("Informe um valor inteiro para B:");

                   try
                   {
                        b[i] = Convert.ToInt32(System.Console.ReadLine());
                        break;
                   }
                   catch (System.Exception)
                   {
                       Console.WriteLine("Valor inválido.");
                   }

                }

                var estaContido = false;

                for (var j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        estaContido = true;
                        b[j] = null;
                        break;
                    }
                }

                if(!estaContido)
                {
                    equal = false;
                }               
            }

            var message = equal ? "Os arrays são iguais." : "Os arrays são diferentes.";
            Console.WriteLine(message);

            // input (1, 2, 3) (3, 2, 1)
            // output (iguais)

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
                while (true)
                {
                    System.Console.WriteLine("Informe um número:");

                    try
                    {
                        a[i] = Convert.ToDouble(Console.ReadLine());
                        soma += a[i];
                        counter++;
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Valor inválido.");
                    }
                }

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

           System.Console.WriteLine($"A média final é {media}");
           System.Console.WriteLine($"{counter2} estão acima da média");
           System.Console.WriteLine($"{counter3} estão na média");
           System.Console.WriteLine($"{counter4} estão abaixo da média");

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

                while (true)
                {
                    System.Console.WriteLine("Informe um número inteiro:");

                    try
                    {
                        a[i] = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Valor inválido!"); 
                    }
                }
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

                while (true)
                {
                    try
                    {
                        b[i] = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Valor inválido!"); 
                    }
                }
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

            int[] a = new int[3];
            var i = 0;

            for(i = 0; i < a.Length; i++)
            {
                while(true)
                {
                    Console.WriteLine("Digite um número inteiro para A:");

                    try
                    {
                        a[i] = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Valor inválido!");
                    }
                }
            }
            
            Array.Clear(a, 0, a.Length);
            
            for(i = 0; i < a.Length; i++)
            {
                while(true)
                {
                    Console.WriteLine("Digite um novo valor para A:");

                    try
                    {
                        a[i] = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Valor inválido!");
                    }
                }
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
            
            int[] a = new int[10];

            for(var i = 0; i < a.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine("Digite um número inteiro:");

                    try
                    {
                        a[i] = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Valor inválido!");
                    }
                }

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
                while (true)
                {
                    Console.WriteLine("Informe um número inteiro positivo:");

                    try
                    {
                        q[i] = Convert.ToInt32(Console.ReadLine());

                        if(q[i] > maior)
                        {
                            maior = q[i];
                            index = i;
                        }
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Valor inválido!");
                    }
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

        static void uri() 
        {
            // Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, 
            // o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor 
            // a ser pago.

            
            string[] product1 = Console.ReadLine().Split(' ');
            int code1 = Convert.ToInt32(product1[0]);
            int amount1 = Convert.ToInt32(product1[1]);
            double price1 = Convert.ToDouble(product1[2]);

            string[] product2 = Console.ReadLine().Split(' ');
            int code2 = Convert.ToInt32(product2[0]);
            int amount2 = Convert.ToInt32(product2[1]);
            double price2 = Convert.ToDouble(product2[2]);

            double totalSale = (amount1 * price1) + (amount2 * price2);
              
            Console.WriteLine($"VALOR A PAGAR: R$ {0:0.00}", totalSale);

        }

        static void questão1() 
        {
            Console.WriteLine("Informe a quantidade de horas e minutos trabalhados por dia:");
            var horas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe qual o valor ganho por hora:");
            var valor = Convert.ToDouble(Console.ReadLine());

            var salarioPorDia = horas * valor;

            Console.WriteLine($"O valor ganho por um dia de trabalho é R${salarioPorDia.ToString("0.00")}");

        }

        static void questão2() 
        {
            string[] word = new string[30];
            var result = "";

            for(var i = 0; i < word.Length; i++)
            {
                Console.WriteLine("Digite uma letra ou digite Finalizar para apresentar a palavra.");
                word[i] = Console.ReadLine();

                if(word[i] != "Finalizar")
                {
                result += word[i];
                }

                if(word[i] == "Finalizar")
                {
                    break;
                }
            }
            
            Console.WriteLine($"{result}");

        }

        static void questão3() 
        {
            string[] nomes = new string[5];
            int[] estadoCivil = new int[5];
            

            for(var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Informe seu nome:");
                nomes[i] = Console.ReadLine();

                Console.WriteLine("Se você é solteiro, digite [1]");
                Console.WriteLine("Se você não é solteiro, digite [0]");
                estadoCivil[i] = Convert.ToInt32(Console.ReadLine());

            }
            
            for(var i = 0; i < nomes.Length; i++)
            {
                if(estadoCivil[i] == 1)
                {
                    Console.WriteLine($"{nomes[i]}");
                }
            }
            
        }

        static void questão4()
        {
            var year = 0;

            while(true)
            {
                Console.WriteLine("Informe seu ano de nascimento:");

                try
                {
                    year = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Valor inválido.");
                }

            }
        
            if(year <= 2002)
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você não é maior de idade.");
            }
            
        }

        static void questão5()
        {

            double?[] num = new double?[5];

            for(var i = 0; i < 5; i++)
            {
                while(true)
                {
                    Console.WriteLine("Informe um número:");

                    try
                    {
                        num[i] = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Número inválido.");
                        num[i] = null;
                        break;
                    }

                }

            }

            Console.WriteLine("Lista de números válidos:");

            for(var i = 0; i < 5; i++)
            {
                if(num[i] != null)
                {
                Console.WriteLine($"{num[i]}");
                }
            }

        }

        static void questão6()
        {
            
            var counter = 0;
            var sum = 0.0;

            while(true)
            {
                Console.WriteLine("Informe o salário:");
                var salary = Convert.ToDouble(Console.ReadLine());
                counter++;
                sum += salary;
                
                if(salary < 0)
                {

                Console.WriteLine("Valor inválido.");
                Console.WriteLine("Informe o salário:");
                salary = Convert.ToDouble(Console.ReadLine());
                counter++;
                sum += salary;

                }

                Console.WriteLine("Para calcular a média salarial, digite [calcular]:");
                Console.WriteLine("Para continuar informando os salários, aperte qualquer tecla.");
                var calculate = Console.ReadLine();

                if(calculate == "calcular")
                {
                    break;
                }
                

            }

            var averageSalary = sum / counter;
            Console.WriteLine($"A média salarial é de R${averageSalary.ToString("0.00")}");

        }

        static void questão7()
        {

            int[] state = new int[5];
            var counter = 0;

            for(var i = 0; i < 5; i++)
            {

                Console.WriteLine("[11] RO\n[12] AC\n[13] AM\n[14] RR\n[15] PA\n[16] AP\n[17] TO\n[21] MA\n[22] PI\n[23] CE\n[24] RN");
                Console.WriteLine("[25] PB\n[26] PE\n[27] AL\n[28] SE\n[29] BA\n[31] MG\n[32] ES\n[33] RJ\n[35] SP\n[41] PR\n[42] SC");
                Console.WriteLine("[43] RS\n[50] MS\n[51] MT\n[52] GO\n[53] DF");
                Console.WriteLine("Digite o ID correspondente ao estado em que você nasceu:");
                state[i] = Convert.ToInt32(Console.ReadLine());

                if(state[i] == 42)
                {
                    counter++;
                }
                
            }

            var percentage = (counter * 100) / 5;
            Console.WriteLine($"O percentual de nascidos em SC é de {percentage}%");



        }

        static void questão8()
        {

            string[] matutino = new string[5];
            string[] vespertino = new string[5];

            for(var i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe o nome do aluno da turma matutina:");
                matutino[i] = Console.ReadLine();

                Console.WriteLine("Informe o nome do aluno da turma vespertina:");
                vespertino[i] = Console.ReadLine();
            }

            var counter = 0;

            for(var i = 0; i < 5; i++)
            {
                if(matutino[i] == vespertino[i])
                {
                    Console.WriteLine($"{matutino[i]}");
                    counter++;                   
                }
                else if(counter == 0)
                {
                    Console.WriteLine("Todos os alunos estudam em meio período.");
                    break;
                }
            }
        }
    }
}
