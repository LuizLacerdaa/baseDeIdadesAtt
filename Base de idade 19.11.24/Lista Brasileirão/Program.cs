using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Brasileirão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> times = new Dictionary<int, string>
            {
                {1, "Botafogo" },
                {2, "Palmeiras" },
                {3, "Fortaleza" },
                {4, "Flamengo" },
                {5, "Internacional" },
                {6, "São Paulo" },
                {7, "Cruzeiro" },
                {8, "Bahia" },
                {9, "Vasco da Grana" },
                {10, "Atlético-MG" },
                {11, "Corinthians" },
                {12, "Grêmio" },
                {13, "Vitoria" },
                {14, "Athletico-PR" },
                {15, "Fluminense" }, 
                {16, "Criciuma" },
                {17, "Juventude" },
                {18, "Bragantino" },
                {19, "Cuiaba" },
                {20, "Atlético-GO" },
            };

            int posiçao = 0;
            
            bool flag = false;
            

            do
            {
                Console.Write("Digite classificação do time: ");
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out posiçao) && posiçao > 0 && posiçao <= 20)
                {
                    flag = true;
                }
                else
                {
                    Console.Write("Entrada Inválida. Por favor, tente novamente: \n");
                }
            }
            while (!flag);

            string nomeTime = times[posiçao];
            Console.WriteLine($"\nTime: {nomeTime}");

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
