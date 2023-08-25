using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefas5
{
    internal class Ex10
    {
        public static void Main(string[] args)
        {
            string linhaF = "*";
            int linha = Convert.ToInt32(Console.ReadLine());
           
        Console.WriteLine("TRIANGULO ISOCELES");
           string tri = "";
            for (int i = 0; i <= linha; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("*");
                }
                else if(i == linha)
                {
                    for (int j = 0; j <= linha; j++)
                    {
                        linhaF += "*";
                    }
                    Console.WriteLine(linhaF);
                }
                else
                {
                    Console.WriteLine("*" + espacosBranco(i) + "*");
                }
                
            }
            Console.WriteLine("TRIANQULO EQUILATERO");
            string ast = "*";
            int qtdAst = 1;
            int qtdBranco = linha + 10;
            
            for (int i = 0; i != linha; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(espacosBranco(qtdBranco) + "*");
                    qtdBranco--;
                }              
                else
                {
                    qtdAst += 2;
                    
                    Console.WriteLine(espacosBranco(qtdBranco) + "" + addAst(qtdAst));
                    qtdBranco--;
                }
                
            }
            
        }

        public static string espacosBranco(int qtd)
        {
            string espaco = "";
            for(int i = 1; i <= qtd; i++)
            {
                espaco += " ";
            }
            return espaco;
        }

        public static string addAst(int qtd)
        {
            string ast = "";
            for (int i = 1; i <= qtd; i++)
            {
                ast += "*";
            }
            return ast;
        }
    }
}
