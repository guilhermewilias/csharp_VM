/*
 Dada uma seqüência de n números (vetor de inteiros), imprimi-la na ordem inversa que foi realizada a leitura
 */

static void main()
{
    int[] numeros = { 1, 2, 3, 4, 5 };

    Array.Reverse(numeros);

    Console.WriteLine("Sequência dos números invertidos : ");
    foreach (int numero in numeros)
    {
           Console.WriteLine(numero + " ");
    }

    Console.ReadKey();
}
main();