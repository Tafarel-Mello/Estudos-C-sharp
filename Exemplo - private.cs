using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Eq2Grau
    {
        private double _a;
        public double a
        {
            get { return _a; }
            set { _a = value; }
        }

        private double _b;

        public double b
        {
            get { return _b; }
            set { _b = value; }
        }

        private double _c;

        public double c
        {
            get { return _c; }
            set { _c = value; }
        }

        private double _Delta;

        public double Delta
        {
            get { return _Delta; }  
            //set { _Delta = value; }
        }

        private double _Raiz1;

        public double Raiz1
        {
            get { return _Raiz1; }
            //set { _Raiz1 = value; }
        }

        private double _Raiz2;

        public double Raiz2
        {
            get { return _Raiz2; }
            //set { _Raiz2 = value; }
        }
        
        public void CalcDelta()
        {
            _Delta = Math.Pow(b, 2) - 4 * a * c;
        }

        public void CalcRaizes()
        {
            _Raiz1 = (-b + Math.Sqrt(Delta)) / (2 * a);
            _Raiz2 = (-b - Math.Sqrt(Delta)) / (2 * a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Eq2Grau Equacao = new Eq2Grau();

            Console.Write("Digite o valor de a: ");
            Equacao.a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            Equacao.b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            Equacao.c = double.Parse(Console.ReadLine());

            Equacao.CalcDelta();

            Console.WriteLine($"\nDelta = {Equacao.Delta:F2}");

            if (Equacao.Delta >= 0)
            {
                Equacao.CalcRaizes();

                Console.WriteLine($"Raiz 1 = {Equacao.Raiz1:F2}");
                Console.WriteLine($"Raiz 2 = {Equacao.Raiz2:F2}");
            }
            else
            {
                Console.WriteLine("A equacao nao possui raizes reais!");
            }

            Console.ReadKey();
        }
    }
}


