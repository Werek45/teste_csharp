using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int cont = 1 ;


            for (cont = 1; cont <=3; cont++)
            {
                    double nota1=0;
               
                    Console.Write("\nPrimeira nota: ");
                    nota1 = double.Parse(Console.ReadLine());

                double nota2;
                
                    Console.Write("Segunda nota: ");
                    nota2 = double.Parse(Console.ReadLine());
                
                double m ;
                m = (nota1 + nota2) / 2;

                Console.WriteLine($"\tA media do {cont}° aluno foi " + m);
                if (m >= 7)
                {
                    Console.WriteLine($"{cont}° aluno, APROVADRO!");
                    if ((m >= 5) && (m < 7))
                    {
                        Console.WriteLine($"{cont}° aluno, em RECUPERÇAO! ");
                    }
                }
                else 
                {
                    Console.WriteLine($"{cont}° aluno, REPROVADO!"); 
                }

            }
               
            

            Console.WriteLine("\n\n\tPrecione qualquer tecla para sair!!");
            Console.ReadKey();
        }
    }
}