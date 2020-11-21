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
            int aprovados = 0;
            int reprovados = 0;
            int totalReprovados = 0;
            int totalAprovados = 0;

                for(var i2 = 0 ; i2 < 10; i2++)
            {
                Console.WriteLine($"Digite as 4 notas do(a) aluno(a): {alunos[i2]}");
                alunos[i2] = Console.ReadLine();
                Console.Write($"Digite a 1° nota:"); nota1[i2] = float.Parse(Console.ReadLine());
                Console.Write($"Digite a 2° nota:"); nota2[i2] = float.Parse(Console.ReadLine());
                Console.Write($"Digite a 3° nota:"); nota3[i2] = float.Parse(Console.ReadLine());
                Console.Write($"Digite a 4° nota:"); nota4[i2] = float.Parse(Console.ReadLine());

                medias[i2] = (nota1[i2] + nota2[i2] + nota3[i2] + nota4[i2])/4;
                System.Console.WriteLine($"A Média do aluno {alunos[i2]} é: {medias[i2]}");
                
                 if(medias[i2] >= 7)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O aluno {alunos[i2]} foi Aprovado!");
                    Console.ResetColor();
                    totalAprovados = aprovados+1;
                } else 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"O aluno {alunos[i2]} foi reprovado!");
                    Console.ResetColor();
                    totalReprovados = reprovados+1;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine("------------------------Cadastrar novo aluno-------------------------");
                Console.ResetColor();
               
            }

            Console.WriteLine($"O total de aprovados é {totalAprovados} e de reprovados é: {totalReprovados}");

            }
        }
 }

