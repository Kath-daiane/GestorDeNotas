using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista para armazenar as notas dos alunos
        List<double> notas = new List<double>();

        // Permite que o usuário insira as notas de 5 alunos
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digite a nota do aluno {i}: ");
            double nota = double.Parse(Console.ReadLine());
            notas.Add(nota);
        }

        // Calcula a média da turma
        double somaNotas = 0;
        foreach (var nota in notas)
        {
            somaNotas += nota;
        }
        double mediaTurma = somaNotas / notas.Count;

        // Exibe a média da turma
        Console.WriteLine($"\nA média da turma é: {mediaTurma:F2}");

        // Exibe os alunos que tiveram notas acima da média
        Console.WriteLine("\nAlunos com notas acima da média:");
        for (int i = 0; i < notas.Count; i++)
        {
            if (notas[i] > mediaTurma)
            {
                Console.WriteLine($"Aluno {i + 1} com nota: {notas[i]:F2}");
            }
        }
    }
}
