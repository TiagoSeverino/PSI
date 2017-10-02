using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaElevador
{
    class Elevador
    {
        private int andar = 0, maxAndar, pessoas = 0, maxPessoas;

        public void setAndar(int andarActual)
        {
            andar = andarActual;
        }

        public int getAndarAtual()
        {
            return andar;
        }

        public void setMaxAndar(int maximoAndar)
        {
            maxAndar = maximoAndar;
        }

        public int getMaxAndar()
        {
            return maxAndar;
        }

        public void setPessoas(int pessoasActuais)
        {
            pessoas = pessoasActuais;
        }

        public int getPessoas()
        {
            return pessoas;
        }

        public void setMaxPessoas(int maximoPessoas)
        {
            maxPessoas = maximoPessoas;
        }

        public int getMaxPessoas()
        {
            return maxPessoas;
        }

        public void Inicializa(int maximoPessoas, int maximoAndares)
        {
            maxPessoas = maximoPessoas;
            maxAndar = maximoAndares;
        }

        public void Entra()
        {
            if (pessoas < maxPessoas)
                pessoas++;
        }

        public void Sai()
        {
            if (pessoas > 0)
                pessoas--;
        }

        public void Sobe()
        {
            if (andar < maxAndar)
                andar++;
        }

        public void Desce()
        {
            if (andar > 0)
                andar--;
        }

        public void Debug()
        {
            Console.WriteLine("O elevador tem {0} pessoas, e está no {1} andar", getPessoas(), getAndarAtual());
        }
    }
}
