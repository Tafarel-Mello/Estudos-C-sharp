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
        // *********  Atributos da classe ***************
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        // **********************************************



        // ********* Construtores da classe *************
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) // o this pega como referencia os outros dois comandos ja passados 
        {
            Deposito(depositoInicial);
        }
        // **********************************************


        // *********** Operacoes da classe **************


        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.00; // taxa
        }


        // ******** To string dos dados da classe *******
        public override string ToString()
        {
            return "Conta: "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo $: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
        // **********************************************



    }
}
