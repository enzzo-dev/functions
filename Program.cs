using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] nota1 = new float[10];
            float[] nota2 = new float[10];
            float[] nota3 = new float[10];
            float[] nota4 = new float[10];
            float[] medias = new float[10];
            string[] alunos = new string[10];

          

                for(var i2 = 1 ; i2 < 10; i2++)
            {
                Console.WriteLine($"Digite as 4 notas do(a) aluno(a): {alunos[i2]}");
                alunos[i2] = Console.ReadLine();
                Console.Write($"Digite a {i2}° nota:"); nota1[i2] = float.Parse(Console.ReadLine());
                Console.Write($"Digite a {i2}° nota:"); nota2[i2] = float.Parse(Console.ReadLine());
                Console.Write($"Digite a {i2}° nota:"); nota3[i2] = float.Parse(Console.ReadLine());
                Console.Write($"Digite a {i2}° nota:"); nota4[i2] = float.Parse(Console.ReadLine());

                medias[i2] = (nota1[i2] + nota2[i2] + nota3[i2] + nota4[i2])/4;
                System.Console.WriteLine($"A Média do aluno {alunos[i2]} é: {medias[i2]}");

                System.Console.WriteLine("------------------------Cadastrar novo aluno-------------------------");
                
               
            }
           
            }
        }
 }

