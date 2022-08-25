using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }



        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }
        public ContaBancaria(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Saldo = depositoInicial;
        }




        public void Deposito(double quantia)
        {
            Saldo += quantia; 
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
        }



        public override string ToString()
        {
            return "Conta: "
                + Numero
                + ", Titular da conta: "
                + Nome
                + ", Saldo atualizado: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
