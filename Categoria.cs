using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce

{
    public class Categoria
    {
        public string Nome { get; private set; }
        public Categoria(string nome)
        {
            Nome = nome;
        }
    }
}
