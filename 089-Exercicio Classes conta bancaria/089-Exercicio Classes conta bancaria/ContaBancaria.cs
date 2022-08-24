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

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular) // o this pega como referencia os outros dois comandos ja passados 
        {
            Saldo = saldo;
        }
        // **********************************************

        public override string ToString()
        {
            return "Conta: "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo $: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
