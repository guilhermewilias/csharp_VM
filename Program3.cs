/*
Considere um vetor de 10 números inteiros positivos maiores que zero e um único número inteiro, também positivo 
e maior que zero. Faça um programa para: 
a. ler pelo teclado o vetor; 
b. ler pelo teclado o número X; 
c. dizer quantos números no vetor são maiores que X, menores que X e iguais a X.
 */

using System;

static void main()
{
    int[] vetor = new int[10];
    Console.WriteLine("Digite 10 números : ");
    for (int i = 0; i < 10; i++)
    {
        while (true)
        {
            Console.WriteLine($"\nNúmero {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out vetor[i]) && vetor[i] > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("\nDigite um número válido.");
            }
        }
    }

    int x;
    while (true)
    {
        Console.WriteLine("\nDigite um número inteiro para x : ");
        if (int.TryParse(Console.ReadLine(),out x) && x > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("\nPor favor, digite um número inteiro positivo");
        }
    }

    int maioresQueX = 0, menoresQueX = 0, iguaisAX = 0;

    foreach (int numero in vetor)
    {
        if (numero > x)
        {
            maioresQueX++;
        }else if (numero < x)
        {
            menoresQueX++;
        }
        else
        {
            iguaisAX++;
        }
    }

    Console.WriteLine($"\nNúmeros no vetor maiores que {x}: {maioresQueX}");
    Console.WriteLine($"\nNúmeros no vetor menores que {x}: {menoresQueX}");
    Console.WriteLine($"\nNúmeros no vetor iguais a {x}: {iguaisAX}");

    Console.ReadKey();

}
main();