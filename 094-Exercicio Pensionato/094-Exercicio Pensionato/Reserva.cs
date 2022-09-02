using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    class Reserva
    {
        public string Nome;
        public string Email;
        public string Telefone;

        public Reserva(string nome, string email, string telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return Nome + ", " + Telefone + ", " + Email;
        }

    }
}
