using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_de_Avalicação
{
    class Carro
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public Piloto piloto { get; set; }

        public void mostarAtributos()
        {
            Console.WriteLine("Marca: {0}\nModelo: {1}:\nPiloto: {2}", marca, modelo, piloto.nome);
        }
    }
}
