using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guardando_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome:");
            string seuNome = Console.ReadLine();
            Console.Write("Digite sua idade:");
            int suaIdade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bem vindo(a) {seuNome}! Você tem {suaIdade} anos.");
            Console.ReadKey();
        }
    }
}
