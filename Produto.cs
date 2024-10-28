using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Produto
    {
        public string Nome { get; private set; }
        public Categoria Categoria { get; private set; }
        public Fornecedor Fornecedor { get; private set; }
        public Produto(string nome, Categoria categoria, Fornecedor fornecedor)
        {
            Nome = nome;
            Categoria = categoria;
            Fornecedor = fornecedor;
        }
    }
}
