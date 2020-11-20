using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] nota1 = new float[4];
            float[] nota2 = new float[4];
            float[] nota3 = new float[4];
            float[] nota4 = new float[4];
            float[] mediaGeral = new float[10];
            float[] mediaDoAluno = new float[5];

            string[] alunos = new string[10];

            for(var i = 0 ; i < 10 ; i++)
            {
                Console.WriteLine($"Digite o nome do {i + 1}° aluno: ");
                alunos[i] = Console.ReadLine();
            }

            for(var i2 = 0 ; i2 < alunos.Length ; i2++)
            {
                Console.WriteLine($"Digite as 4 notas do(a) aluno(a): {alunos[i2]}");
                nota1[i2] = float.Parse(Console.ReadLine());
                nota2[i2] = float.Parse(Console.ReadLine());
                nota3[i2] = float.Parse(Console.ReadLine());
                nota4[i2] = float.Parse(Console.ReadLine());
            }

            for(var count = 0 ; count < 4 ; count++)
            {
                mediaGeral[count] = nota1[count] + nota2[count] + nota3[count] + nota4[count] / 4;
                System.Console.WriteLine($"A média geral da turma é: {mediaGeral} ");
            }
        }
    }
}
