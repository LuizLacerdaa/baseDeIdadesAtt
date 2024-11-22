using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Base_de_idade_19._11._24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade = 0;
            bool flag = false;

            do
            {
                Console.Write("Digite a idade da pessoa: ");
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out idade) && idade >= 0)
                {
                    flag = true;
                }
                else
                {
                    Console.Write("Entrada Inválida. Por favor, tente novamente: \n");
                }
            } while (!flag);
            
                if (idade <= 12)
                    Console.WriteLine("Essa pessoa é uma criança.");
                else if (idade <= 17)
                    Console.WriteLine("Essa pessoa é um adolescente.");
                else if (idade <= 59)
                    Console.WriteLine("Essa pessoa é um adulto.");
                else
                    Console.WriteLine("Essa pessoa é um idoso.");
            
            Console.ReadKey();
        }
    }
}
