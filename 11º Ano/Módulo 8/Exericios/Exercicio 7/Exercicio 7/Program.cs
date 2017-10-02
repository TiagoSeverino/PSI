using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0;
            int mais_novo = 0, mais_velho = 0, na = 25;

            for(int i = 0; i < na; i++)
            {
                Console.WriteLine("Insira a idade do aluno");
                int idade = Int32.Parse(Console.ReadLine());

                if(i == 0 || idade < mais_novo)
                {
                    mais_novo = idade;
                }

                if (i == 0 || idade > mais_velho)
                {
                    mais_velho = idade;
                }

                media += (double)idade / na;
            }

            Console.WriteLine("A média das idades é de " + media + " anos, o aluno mais velho tem " + mais_velho + " anos e o aluno mais novo tem " + mais_novo + " anos");
            Console.ReadLine();
        }
    }
}
