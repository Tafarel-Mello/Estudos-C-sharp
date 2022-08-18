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
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        // ********************


        // Encapsulamentos *********************

        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1) // com o atributo "set" posso atrinuir uma logica para aceitar ou regeitar alteracoes
            {
                _nome = nome;
            }
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


