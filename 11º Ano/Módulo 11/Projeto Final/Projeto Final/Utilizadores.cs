using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    static class Utilizadores
    {
        const string Admin = "a";
        const string AdminPass = "a";

        const string Biblioteca = "Biblioteca";
        const string BibliotecaPass = "123";

        public static bool Valida(string user, string pass)
        {
            if (user.ToLower().Equals(Admin.ToLower()) && pass.Equals(AdminPass))
                return true;

            if (user.ToLower().Equals(Biblioteca.ToLower()) && pass.Equals(BibliotecaPass))
                return true;

            return false;
        }
    }
}
