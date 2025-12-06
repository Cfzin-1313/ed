using System;
class Program
{
    static void Main()
    {
    int[][] notasAlunos = new int[3][];
        notasAlunos[0] = new int[] { 10, 15, 20 }; 
        notasAlunos[1] = new int[] { 30, 40 }; 
        notasAlunos[2] = new int[] { 50, 60, 70, 80 }; 
                                                       
        Console.WriteLine("--- Estrutura de Notas ---");
        for (int i = 0; i < notasAlunos.Length; i++)
        {
            Console.Write($"Aluno {i}: ");
            for (int j = 0; j < notasAlunos[i].Length; j++)
            {
                Console.Write(notasAlunos[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nDigite uma nota para buscar:");
        int notaBusca = int.Parse(Console.ReadLine());
        bool encontrada = BuscaSequencial(notasAlunos, notaBusca);
        if (encontrada)
            Console.WriteLine($"A nota {notaBusca} foi encontrada no sistema.");
        else
            Console.WriteLine($"A nota {notaBusca} NÃO consta nos registros.");
    }
    
    static bool BuscaSequencial(int[][] matriz, int valorProcurado)
    {
        for (int i = 0; i < matriz.Length; i++)
        {
            for (int j = 0; j < matriz[i].Length; j++)
            {
                if (matriz[i][j] == valorProcurado)
                {
                    Console.WriteLine($"[DEBUG] Encontrado no Aluno {i}, Prova {j}");
                    return true;
                }
            }
        }
        return false;
    }
}
