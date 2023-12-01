/*
Uma agência de publicidade pediu à agência de modelos Luz & Beleza para encontrar uma modelo que tenha 
idade entre 18 e 20 anos para participar de uma campanha publicitária milionária de produtos de beleza. Foram 
inscritas 20 candidatas e, ao se inscreverem, forneceram nome e idade. Tais informações foram armazenadas em 
2 vetores distintos. Faça um programa para imprima o vetor que contém os nomes das candidatas aptas a 
concorrer a uma vaga para a campanha milionária. 
 */

static void main()
{
    int numeroCandidatas = 20;

    string[] nomes = new string[numeroCandidatas];
    int[] idades = new int[numeroCandidatas];

    for (int i = 0; i < numeroCandidatas; i++)
    {
        Console.WriteLine($"Digite o número da candidata : {i + 1}");
        nomes[i] = Console.ReadLine();

        while (true)
        {
            Console.Write($"Digite a idade da candidata {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out idades[i]) && idades[i] >= 18 && idades[i] <= 20)
            {
                break;
            }
            else
            {
                Console.WriteLine("A idade deve ser entre 18 e 20 anos");
            }
        }
    }

    Console.WriteLine("\nCanditadas aptas para a campanha milionária : ");
    for (int i = 0;i < numeroCandidatas;i++)
    {
        if (idades[i] >= 18 && idades[i] <= 20)
        {
            Console.WriteLine(nomes[i]);
        }
    }

    Console.ReadKey();
}
main();