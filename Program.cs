﻿using System;

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
            float[] mediaGeral = new float[10];

            string[] alunos = new string[10];
            int aprovados = 0;
            int reprovados = 0;

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
                    aprovados = aprovados + 1;
                } else if(medias[i2] < 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"O aluno {alunos[i2]} foi reprovado!");
                    Console.ResetColor();
                    reprovados = reprovados + 1;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine("------------------------Cadastrar novo aluno-------------------------");
                Console.ResetColor();
               
            }
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"Tivemos {aprovados} alunos aprovados!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"Tivemos {reprovados} alunos reprovados!");
                Console.ResetColor();


                float calculoMedia(float a, float b, float c, float d, float e,float f,float g,float h,float i,float j)
                {
                    float calcularMedia = (a+b+c+d+e+f+g+h+i+j)/10;    
                    return calcularMedia;
                }

                 Console.ForegroundColor = ConsoleColor.Yellow;
                 System.Console.WriteLine($"A média geral da sala é: {calculoMedia(medias[0],medias[1],medias[2],medias[3],medias[4],medias[5],medias[6],medias[7],medias[8],medias[9])}");
                 Console.ResetColor();
        }
 }
}

