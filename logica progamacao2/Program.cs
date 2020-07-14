using Microsoft.VisualBasic;
using System;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace logica_progamacao2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Estrutura de Dados
            //pilha last in, first out - LIFO
            //fila first in, first out - FIFO
            //lista não - organizada / não - sequencial

            //Pilha 

            int[] numeros = new int[10];

            //Estrutura de atribuição de dados

            for (int i = 0; i < 10; i++)
            {
                numeros[i] = i;
            }

            //estrutura de impressão de dados

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }

            //Fila

            //int[] numeros = new int[10];

            ////Estrutura de atribuição de dados

            //for (int i = 0; i < 10; i++)
            //{
            //    numeros[i] = i;
            //}

            ////estrutura de impressão de dados

            //for (int i = 0; i <10; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}


            //Lista

            //int[] numeros = new int[5];
            //numeros [3] = 1;
            //numeros[4] = 10;

            //Console.WriteLine(numeros[3]);
            //Console.WriteLine(numeros[4]);



            // Estrutura de repetição

            //int resposta = 0;
            //int erro = 0;
            //int count = 1;

            //while (resposta !=2)
            //{
            //    if (count >= 2)
            //        erro++;

            //    Console.WriteLine("qual o nome do atual presidente do brasil?");
            //    Console.WriteLine("1 - fernando henrique cardoso");
            //    Console.WriteLine("2 - jair bolsonaro");
            //    Console.WriteLine("3 - lula");
            //    Console.WriteLine("4 - tancredo neves");
            //    Console.WriteLine("5 - Dilma");
            //    Console.WriteLine("6 - castelo branco");
            //    Console.WriteLine("7 - sarneys");


            //   resposta = Convert.ToInt32(Console.ReadLine());
            //}

            //count++;

            //double nota = 10;

            //if (erro > 0)

            //    nota = nota / erro;

            //Console.WriteLine($"venceu! sua nota é: {nota}");



            //Console.WriteLine("qual o nome do atual presidente do brasil?");
            //Console.WriteLine("1 - fernando henrique cardoso");
            //Console.WriteLine("2 - jair bolsonaro");
            //Console.WriteLine("3 - lula");
            //Console.WriteLine("4 - tancredo neves");
            //Console.WriteLine("5 - Dilma");
            //Console.WriteLine("6 - castelo branco");
            //Console.WriteLine("7 - sarneys");


            //int resposta = Convert.ToInt32(Console.ReadLine());

            //    if (resposta ==2)
            //{
            //    Console.WriteLine("venceu!");
            //}
            //    else
            //{
            //    Console.WriteLine("perdeu");
            //}

            //// for 

            //Console.WriteLine("digite o numero inicial");
            //int inicial = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("digite o numero final");
            //int final = Convert.ToInt32(Console.ReadLine());

            //if (final <= inicial)


            //    Console.WriteLine("erro: o numero final não pode ser menor do que o numero inicial");


            //else
            //{
            //    Console.WriteLine("numeros impares (i) ou numeros pares (p): ");
            //    string tipo = Console.ReadLine();
            //    switch (tipo.ToLower())
            //    {
            //        case "p":

            //            for (int i = inicial; i <= final; i++)

            //                if (i % 2 == 0)
            //                { Console.WriteLine(i); }

            //            break;

            //        case "i":

            //            for (int i = inicial; i <= final; i++)

            //                if (i % 2 == 1)
            //                { Console.WriteLine(i); }

            //            break;

            //        default:

            //            Console.WriteLine("Você não digitou o tipo de numero correto");
            //            break;
            //    }

            //Console.WriteLine("digite o numero inicial");
            //int inicial = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("digite o numero final");
            //int final = Convert.ToInt32(Console.ReadLine());

            //if (final <= inicial)


            //    Console.WriteLine("erro: o numero final não pode ser menor do que o numero inicial");


            //else
            //{
            //    Console.WriteLine("numeros impares (I) ou numeros pares (P): ");
            //    string tipo = Console.ReadLine();
            //    switch (tipo)
            //    {
            //        case "P":

            //            for (int i = inicial; i <= final; i++)

            //                if (i % 2 == 0)
            //                { Console.WriteLine(i); }

            //            break;

            //        case "I":

            //            for (int i = inicial; i <= final; i++)

            //                if (i % 2 == 1)
            //                { Console.WriteLine(i); }

            //        break;

            //        default:

            //            Console.WriteLine("Você não digitou o tipo de numero correto");
            //            break;
            //        }








            //// while

            //int numero = 1;
            //while (numero % 2 == 1) // impar
            //{
            //    Console.WriteLine("digite um numero par:");
            //    numero = Convert.ToInt32(Console.ReadLine());

            //}

            //Console.WriteLine("obrigado por digitar um numero par!");


            //for (int i = 1; i <= 50; i++)
            //    if (i % 2 == 1) //par
            //    {
            //        Console.WriteLine(i);
            //    }

            //for (int i = 1; i <=50; i++)
            //    if (i % 2 == 0) //par
            //{
            //        Console.WriteLine(i);
            //}


            //int inteiro = 14 / 7;
            //Console.WriteLine(inteiro);

            //int inteiro = 13 % 2;
            //Console.WriteLine(inteiro);



            //for (int i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // while

            //int inteiro = 0;
            //while (inteiro <10)
            //{
            //    Console.WriteLine(inteiro);
            //    inteiro = inteiro + 1;
            //}

        }
    }
}
