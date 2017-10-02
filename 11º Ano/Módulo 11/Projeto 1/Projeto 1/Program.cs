using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    class Program
    {
        List<Empregado> Trabalhadores = new List<Empregado>();

        const string Titulo = "Gestão de Trabalhadores - Sousa Lda";

        static void Main(string[] args)
        {
            Program prg = new Program();
            prg.Menu();
        }

        private void Menu()
        {
            Console.Title = Titulo;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("1- Ver Dados do Empregado\n" +
                                  "2- Contratar Novo Empregado\n" +
                                  "3- Demitir um Funcionário\n" +
                                  "4- Sair");

                GereOpção();
            }
        }

        private int GetOpção(string opção)
        {
            int Opção;
            try
            {
                Opção = int.Parse(opção);
            }
            catch
            {
                Opção = 0;
                Console.WriteLine("Opção Invalida!");
                Console.ReadLine();
            }
            return Opção;
        }

        private void GereOpção()
        {
            switch (GetOpção(Console.ReadLine()))
            {
                case 1:
                    VerDados();
                    break;

                case 2:
                    NovoEmpregado();
                    break;

                case 3:
                    DemitirEmpregado();
                    break;
                case 4:
                    Sair();
                    break;
            }
        }

        private void VerDados()
        {
            Console.Clear();

            List<EmpregadoPermanente> empregadosPermanentes = new List<EmpregadoPermanente>();
            List<EmpregadoTemporário> empregadosTemporários = new List<EmpregadoTemporário>();
            List<EmpregadoVendedor> empregadosVendedores = new List<EmpregadoVendedor>();


            foreach(Empregado empregado in Trabalhadores)
            {
                if (empregado.GetType().Name == "EmpregadoPermanente")
                    empregadosPermanentes.Add((EmpregadoPermanente)empregado);

                if (empregado.GetType().Name == "EmpregadoTemporário")
                    empregadosTemporários.Add((EmpregadoTemporário)empregado);

                if (empregado.GetType().Name == "EmpregadoVendedor")
                    empregadosVendedores.Add((EmpregadoVendedor)empregado);
            }

            if(empregadosPermanentes.Count > 0)
            {
                Console.WriteLine("\nNome | Estatuto | Dias Trabalhados No Mês | Salário Mensal Fixo | Número De Filhos | Estadocivil | Bónus Mensal | Estado Civil");
                foreach(EmpregadoPermanente empregado in empregadosPermanentes)
                    empregado.Informação();
            }

            if (empregadosTemporários.Count > 0)
            {
                Console.WriteLine("\nNome | Estatuto | Salário/Hora | Horas Trabalhadas No Mês");
                foreach (EmpregadoTemporário empregado in empregadosTemporários)
                    empregado.Informação();
            }

            if (empregadosVendedores.Count > 0)
            {
                Console.WriteLine("\nNome | Estatuto | Salário/Hora | Horas Trabalhadas No Mês | Volume Vendas | Comissão");
                foreach (EmpregadoVendedor empregado in empregadosVendedores)
                    empregado.Informação();
            }

            Console.ReadLine();
        }

        private void NovoEmpregado()
        {
            MenuTipoEmpregado();

            switch (GetOpção(Console.ReadLine()))
            {
                case 1:
                    NovoPermanente();
                    break;

                case 2:
                    NovoTemporário();
                    break;

                case 3:
                    NovoVendedor();
                    break;

                case 4:
                    VoltarMenuInicial();
                    break;
            }
        }

        private void MenuTipoEmpregado()
        {
            Console.Clear();

            Console.WriteLine("1- Permanente\n" +
                              "2- Temporário\n" +
                              "3- Temporário Vendedor\n" +
                              "4- Voltar Ao Menu Inicial");
        }

        private void NovoPermanente()
        {
            Trabalhadores.Add(new EmpregadoPermanente(GetNome(), GetInt("Meses Trabalhados No Mês: "), GetDouble("Salário Mensal Fixo: "), GetInt("Número de Filhos: "), GetEstadoCivil(), GetDouble("Bónus Mensal Por Criança: ")));
        }

        private void NovoTemporário()
        {
            Trabalhadores.Add(new EmpregadoTemporário(GetNome(), GetDouble("Salário Por Hora: "), GetInt("Horas Trabalhadas Por Mês: ")));
        }

        private void NovoVendedor()
        {
            Trabalhadores.Add(new EmpregadoVendedor(GetNome(), GetDouble("Salário Por Hora: "), GetInt("Horas Trabalhadas Por Mês: "), GetDouble("Volume de Vendas: "), GetDouble("Comissão: ")));
        }

        private void VoltarMenuInicial()
        {
            Menu();
        }

        private string GetNome()
        {
            Console.Clear();
            Console.Write("Insira o nome do funcionário: ");
            return Console.ReadLine();
        }

        private int GetInt(string Msg)
        {
            int nr = 0;

            Console.Write(Msg);

            try
            {
                nr = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType());
            }

            return nr;
        }

        private double GetDouble(string Msg)
        {
            double nr = 0;

            Console.Write(Msg);

            try
            {
                nr = Double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
            }

            return nr;
        }

        private string GetEstadoCivil()
        {
            Console.WriteLine("Estado Civil:\n" +
                              "1- Solteiro\n" +
                              "2- Casado\n" +
                              "3- Divorciado\n" +
                              "4- Viuvo");

            switch (GetInt(""))
            {
                case 1:
                    return EstadoCivil.Solteiro;
                case 2:
                    return EstadoCivil.Casado;
                case 3:
                    return EstadoCivil.Divorciado;
                case 4:
                    return EstadoCivil.Viuvo;
            }

            return "";
        }

        private void DemitirEmpregado()
        {
            Console.Write("Nome do Empregado: ");
            DemiteEmpregado(Console.ReadLine());
        }

        private void DemiteEmpregado(string Nome)
        {
            bool apagou = false;

            for(int i = 0; i < Trabalhadores.Count; i++)
            {
                if(Trabalhadores[i].nome == Nome)
                {
                    Trabalhadores.RemoveAt(i);
                    apagou = true;
                }
            }

            if (apagou)
                Console.WriteLine("{0} Demitido com Sucesso!", Nome);
            else
                Console.WriteLine("{0} Não Encontrado!", Nome);

            Console.ReadLine();
        }

        private void Sair()
        {
            Environment.Exit(0);
        }
    }
}
