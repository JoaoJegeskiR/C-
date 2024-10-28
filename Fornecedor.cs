using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Fornecedor
    {
        public string Nome { get; private set; }
        public Fornecedor(string nome)
        {
            Nome = nome;
        }
    }
}