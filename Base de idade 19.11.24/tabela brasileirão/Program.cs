using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabela_brasileirão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posiçao = 0;
            bool flag = false;

            do
            {
                Console.Write("Digite classificação do time: ");
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out posiçao) && posiçao >0 && posiçao <=20) 
                {
                    flag = true;
                }                
                else
                {
                    Console.Write("Entrada Inválida. Por favor, tente novamente: \n");
                }
            }
            while (!flag);

            if (posiçao <= 4)
                Console.WriteLine("Esse time está classificado para a Copa Libertadores.");
            else if (posiçao <= 6)
                Console.WriteLine("Esse time está classificado para as Qualificatórias da Libertadores.");
            else if (posiçao <= 12)
                Console.WriteLine("Esse time está classificado para a Copa Sul-Americana.");
            else if (posiçao <= 20)
                Console.WriteLine("Esse time está na fase de Rebaixamento.");


            Console.ReadKey();
        }
    }
}
