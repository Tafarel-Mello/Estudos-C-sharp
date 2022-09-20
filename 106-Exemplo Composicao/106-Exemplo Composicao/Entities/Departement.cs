using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106_Exemplo_Composicao.Entities
{
    class Departement
    {
        public string Name { get; set; }

        public Departement()
        {
        }

        public Departement(string name)
        {
            Name = name;
        }
    }
}
