using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1
{
    class Program
    {
        static Queue<string>[] Filas = new Queue<string>[4];
        static string[] dentistas = { " Drª Carla", "Drª Rita", "Dr João", "Dr Pedro" };

        static void Main(string[] args)
        {
            for (int i = 0; i < Filas.Length; i++)
                Filas[i] = new Queue<string>();

            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("a) Inserir um paciente na fila.");
            Console.WriteLine("b) Procurar um paciente na fila.");
            Console.WriteLine("c) Remover um paciente da fila.");
            Console.WriteLine("d) Mostrar o conteúdo da fila.");

            Console.Write("Selecione uma opção:");
            char Opção = Console.ReadLine().ToLower()[0];

            if (Opção >= 'a' & Opção <= 'd')
            {
                Console.Clear();

                switch (Opção)
                {
                    case 'a':
                        InserirPaciente();
                        break;
                    case 'b':
                        ProcurarPaciente();
                        break;
                    case 'c':
                        RemoverPaciente();
                        break;
                    case 'd':
                        MostrarPacientes();
                        break;
                }
                Console.ReadLine();
            }
            MainMenu();
        }

        static void InserirPaciente()
        {
            Console.Write("Nome do Paciente: ");
            string nome = Console.ReadLine();

            int fila = GetFila();

            Console.WriteLine("Encontram-se {0} pessoas na fila.", Filas[fila].Count);

            int menor = fila;

            for(int i = 0; i< Filas.Length; i++)
            {
                if (i != fila && Filas[i].Count < Filas[menor].Count)
                {
                    menor = i;
                }
            }

            if (menor != fila)
            {
                Console.WriteLine("A fila do/a {0} só tem {1} pessoas, deseja mudar (s/N)?", dentistas[menor], Filas[menor].Count);
                Console.Write("Selecione uma opção:");
                char Opção = Console.ReadLine().ToLower()[0];

                if (Opção == 's')
                {
                    fila = menor;
                }
            }

            Filas[fila].Enqueue(nome);
            Console.WriteLine("{0} foi adicionado á fila do/a {1}", nome, dentistas[fila]);
        }

        static void ProcurarPaciente()
        {
            int fila = GetFila();

            Console.Write("Nome do Paciente: ");
            string nome = Console.ReadLine();

            if (Filas[fila].Contains(nome))
            {
                
                int i = 0;
                for (; i < Filas[fila].Count; i++)
                    if (Filas[fila].ElementAt(i) == nome)
                        break;

                Console.WriteLine("Encontram-se {0} pessoas de momento a sua frente.", i);
            }
            else
            {
                Console.WriteLine("Paciente não encontrado.");
            }
            
        }

        static void RemoverPaciente()
        {
            int fila = GetFila();
            if (Filas[fila].Count > 0)
                Filas[fila].Dequeue();
        }

        static void MostrarPacientes()
        {
            int fila = GetFila();

            Console.WriteLine("Fila do/a {0}, com {1} pessoa/s:", dentistas[fila], Filas[fila].Count);

            foreach(string pessoa in Filas[fila])
            {
                Console.WriteLine("\t" + pessoa);
            }
        }

        static int GetFila()
        {
            int fila = -1;
            while (fila == -1)
            {
                Console.WriteLine("Nome do médico:");
                Console.WriteLine("a) Drª Carla.");
                Console.WriteLine("b) Drª Rita.");
                Console.WriteLine("c) Dr João.");
                Console.WriteLine("d) Dr Pedro.");

                Console.Write("Selecione uma opção:");
                char Opção = Console.ReadLine().ToLower()[0];

                if (Opção >= 'a' & Opção <= 'd')
                {

                    switch (Opção)
                    {
                        case 'a':
                            fila = 0;
                            break;
                        case 'b':
                            fila = 1;
                            break;
                        case 'c':
                            fila = 2;
                            break;
                        case 'd':
                            fila = 3;
                            break;
                    }
                }
            }
            return fila;
        }
    }
}
