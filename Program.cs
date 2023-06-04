namespace Aula10;
class Program
{
    static void Main(string[] args)
    {
        /*Questão 1. Intercalação é o processo utilizado para construir uma tabela ordenada, de tamanho m + n, a
        partir de duas tabelas já ordenadas de tamanhos m e n. Por exemplo, a partir das tabelas A e B
        construímos a tabela C:
        Faça um programa que:
        a) leia NA, número de elementos do conjunto A (NA < 100);
        b) leia, em seguida, os elementos do conjunto A;
        c) leia, logo após o valor de NB, número de elementos do conjunto B (NB < 100);
        d) crie e imprima um conjunto C, ordenado, de tamanho NA + NB, a partir dos conjuntos originais A e B.
        Observações:
        1. Considerar os elementos de A e B como inteiros.
        2. Os elementos de A e B já são lidos ordenados.
        3. A leitura dos valores dos vetores A e B deve ser feita através de um método. A intercalação também
        deverá ser feita através de um método que irá receber os vetores A e B já preenchidos.*/

        int a, b;

        Console.WriteLine("Digite o tamanho do vetor A e B: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        int[] veta = new int[a];
        int[] vetb = new int[b];
        Aleatorio(veta);
        Aleatorio(vetb);

        Console.WriteLine("Vetor A: ");
        Ordenacao(veta);
        Console.WriteLine("\n\nVetor B: ");
        Ordenacao(vetb);
        Console.WriteLine("\n\nVetor C: ");

        int[] vetc = SomaVetor(veta, vetb);

    }

    static int[] Ordenacao(int[] num)
    {
        int temp, permuta = 1;

        while (permuta == 1)
        {
            permuta = 0;
            for (int i = 0; i < num.Length - 1; i++)
            {

                if (num[i] > num[i + 1])
                {

                    temp = num[i];
                    num[i] = num[i + 1];
                    num[i + 1] = temp;
                    permuta = 1;
                }
            }

        }
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
        return num;
    }

    static int[] Aleatorio(int[] a)
    {
        Random rd = new Random();
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rd.Next(1, 100);
        }

        return a;
    }

    static int[] SomaVetor(int[] a, int[] b)
    {
        int[] vetc = new int[a.Length + b.Length];
        int cont = 0;

        for (int i = 0; i < a.Length; i++)
        {
            vetc[cont] = a[i];
            cont++;
        }

        for (int i = 0; i < b.Length; i++)
        {
            vetc[cont] = b[i];
            cont++;
        }

        Ordenacao(vetc);
        return vetc;
    }
}
