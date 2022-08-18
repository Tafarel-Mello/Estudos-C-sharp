using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;




        // construtores ***************
        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade) // o construtor obria a instanciacao no momento da construcao
        {
            _nome = nome; // esse valor entra como value no properties abaixo
            _preco = preco;
            _quantidade = quantidade;
        }
        // ********************


        // Encapsulamentos com properties *********************

       
        public string Nome
        {
            get { return _nome; }
            set {
                if(value != null && value.Length > 1) // value vai receber o valor de "nome" que foi instanciado
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco;  }
        }
        public int Quantidade
        {
            get { return _quantidade; }
        }


        // **************************************







        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade) // esta funcao e 'void' pq ela nao retorna valor, mas ela altera uma variavel
        {
            _quantidade = _quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade) // esta funcao e 'void' pq ela nao retorna valor, mas ela altera uma variavel
        {
            _quantidade = _quantidade - quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}


