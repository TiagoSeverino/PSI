using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class TestaFuncionários
    {
        public void inicio()
        {
            List<Funcionario> Funcionarios = new List<Funcionario>();

            Funcionarios.Add(new Caixa { Nome = "Joaquim", Salário = 1000, Balcão = 1 });
            Funcionarios.Add(new Telefonista { CodeEstação = "1", Nome = "Joaquim", Salário = 1500 });
            Funcionarios.Add(new Gerente { Nome = "Joaquim", Salário = 5000, User = "Gerente_Joaquim", Pass = "Joaquim123" });

            foreach (Funcionario funcionario in Funcionarios)
            {
                Console.WriteLine(funcionario.aumentaSalário());
                Console.WriteLine(funcionario.mostraDados());
            }
                

            Console.ReadLine();
        }
    }
}
