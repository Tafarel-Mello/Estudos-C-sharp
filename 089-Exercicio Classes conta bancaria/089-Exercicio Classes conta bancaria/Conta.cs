using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    class Conta
    {
        private int _numeroConta;
        private string _nomeTitular;
        private char _depositoInicial;
        private float _saldoInicial, _saldo;


        public Conta(int numeroConta, string nomeTitular)
        {
            _numeroConta = numeroConta;
            _nomeTitular = nomeTitular;
        }

        public Conta(int numeroConta, string nomeTitular, char depositoInicial, float saldoInicial, float saldo)
        {
            _numeroConta = numeroConta;
            _nomeTitular = nomeTitular;
            _depositoInicial = depositoInicial;
            _saldoInicial = saldoInicial;
            _saldo = saldo;
        }



    }
}
