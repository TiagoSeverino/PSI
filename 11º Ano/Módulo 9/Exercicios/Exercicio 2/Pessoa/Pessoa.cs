using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    class Pessoa
    {
        private string nome;
        private int idade;
        private double altura;

        public Pessoa(string name, int age, double height)
        {
            nome = name;
            idade = age;
            altura = height;
        }

        public void setIdade(int age)
        {
            idade = age;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setAltura(double height)
        {
            altura = height;
        }

        public double getAltura()
        {
            return altura;
        }
        

        public void setNome(string name)
        {
            nome = name;
        }

        public string getNome()
        {
            return nome;
        }
    }
}
