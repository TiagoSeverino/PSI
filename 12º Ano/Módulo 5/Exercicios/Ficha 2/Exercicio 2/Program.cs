using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    struct Contacto{
        public string Nome;
        public string Número;
        public string Morada;

        public Contacto(string Nome, string Número, string Morada)
        {
            this.Nome = Nome;
            this.Número = Número;
            this.Morada = Morada;
        }
    }
    class Program
    {
        static Contacto[] Agenda;
        static void Main(string[] args)
        {
            Console.Write("Número de Pessoas na Agenda: ");

            Agenda = new Contacto[int.Parse(Console.ReadLine())];

            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma opção:");

            Console.WriteLine("a) Registar os contactos da agenda.");
            Console.WriteLine("b) Apresentar todos os contatos.");
            Console.WriteLine("c) Efetuar a pesquisa de contatos tendo por base nome.");
            Console.WriteLine("d) Apresentar a lista de contactos ordenada pelo nome da pessoa.");

            char Opção = Console.ReadLine().ToLower()[0];

            if (Opção >= 'a' & Opção <= 'd')
            {
                Console.Clear();

                switch (Opção)
                {
                    case 'a':
                        RegistarContacto();
                        break;
                    case 'b':
                        ApresentarContactos();
                        break;
                    case 'c':
                        PesquisarContactos();
                        break;
                    case 'd':
                        MostrarContactosOrdenados();
                        break;
                }
                Console.ReadLine();
            }
            MainMenu();
        }

        static void RegistarContacto()
        {
            Console.WriteLine("a) Registar	os	contactos	da	agenda.");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Número: ");
            string Número = Console.ReadLine();
            Console.Write("Morada: ");
            string Morada = Console.ReadLine();

            for(int i = 0; i < Agenda.Length; i++)
            {
                if (Agenda[i].Nome == null)
                {
                    Agenda[i].Nome = Nome;
                    Agenda[i].Número = Número;
                    Agenda[i].Morada = Morada;

                    Console.WriteLine("Contacto Registado Com Sucesso!");
                    return;
                }
            }

            Console.WriteLine("Agenda Cheia!");
        }

        static void ApresentarContactos()
        {
            foreach (Contacto contacto in Agenda)
            {
                if (contacto.Nome != null)
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine("Nome: " + contacto.Nome);
                    Console.WriteLine("Número: " + contacto.Número);
                    Console.WriteLine("Morada: " + contacto.Morada);
                }
            }
        }

        static void PesquisarContactos()
        {
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();

            int i = 0;
            foreach (Contacto contacto in Agenda)
            {
                if (contacto.Nome != null && contacto.Nome.ToLower().Contains(Nome.ToLower()))
                {
                    i++;
                    Console.WriteLine("===============================");
                    Console.WriteLine("Nome: " + contacto.Nome);
                    Console.WriteLine("Número: " + contacto.Número);
                    Console.WriteLine("Morada: " + contacto.Morada);
                }
            }

            if (i == 0)
                Console.WriteLine("Contacto Não Encontrado");
        }

        static void MostrarContactosOrdenados()
        {
            var TempAgenda = Agenda.OrderBy(Contacto => Contacto.Nome);

            foreach (Contacto contacto in TempAgenda)
            {
                if (contacto.Nome != null)
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine("Nome: " + contacto.Nome);
                    Console.WriteLine("Número: " + contacto.Número);
                    Console.WriteLine("Morada: " + contacto.Morada);
                }
            }
        }
    }
}
