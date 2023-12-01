/*
Dados dois vetores x e y, ambos com n elementos, determinar o produto escalar desses vetores. Ou seja, realizar 
a soma de todos dos resultados da multiplicação de x[i] por y[i]. 
 */

using System;

static void main()
{
    int[] x = { 1, 2, 3, 4, 5 };
    int[] y = { 1, 2, 3, 4, 5 };

    if (x.Length != y.Length)
    {
        Console.WriteLine("Os vetores tem que ter o mesmo tamanho.");
        return;
    }

    int produtoEscalar = calcularProdutoEscalar(x, y);

    Console.WriteLine($"O produto escalar dos vetores é : {produtoEscalar}");

    Console.ReadKey();

    static int calcularProdutoEscalar(int[] vetor1, int[] vetor2)
    {
        int resultado = 0;

        if (vetor1.Length != vetor2.Length)
        {
            throw new ArgumentException("Os vetores devem ter o mesmo tamanho");
        }

        for (int i = 0; i < vetor1.Length; i++)
        {
            resultado += vetor1[1] * vetor2[2];
        }

        return resultado;
    }
}
main();
