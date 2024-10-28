using System;
using System.Collections.Generic;

namespace Ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            Iniciar();
        }

        static void Iniciar()
        {
            List<Categoria> categorias = new List<Categoria>();
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            List<Produto> produtos = new List<Produto>();
            PopularBancoDados(categorias, fornecedores, produtos);

            int opcao;
            do
            {
                Console.WriteLine("BEM VINDO AO MEU ERP DE VENDAS DE CELULARES");
                Console.WriteLine("(1) - Cadastro de Categorias");
                Console.WriteLine("(2) - Cadastro de Fornecedores");
                Console.WriteLine("(3) - Cadastro de Produtos");
                Console.WriteLine("(4) - Listar Categorias");
                Console.WriteLine("(5) - Listar Fornecedores");
                Console.WriteLine("(6) - Listar Produtos");
                Console.WriteLine("(0) - Sair");
                Console.Write("Digite sua opção: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ModuloCategoria(categorias);
                        break;
                    case 2:
                        ModuloFornecedor(fornecedores);
                        break;
                    case 3:
                        ModuloProduto(produtos, categorias, fornecedores);
                        break;
                    case 4:
                        ListarCategorias(categorias);
                        break;
                    case 5:
                        ListarFornecedores(fornecedores);
                        break;
                    case 6:
                        ListarProdutos(produtos);
                        break;
                    case 0:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

            } while (opcao != 0);
        }

        static void PopularBancoDados(List<Categoria> categorias, List<Fornecedor> fornecedores, List<Produto> produtos)
        {
            categorias.Add(new Categoria("Smartphones"));
            categorias.Add(new Categoria("Acessórios"));
            categorias.Add(new Categoria("Carregadores"));

            fornecedores.Add(new Fornecedor("Samsung"));
            fornecedores.Add(new Fornecedor("Apple"));

            produtos.Add(new Produto("Galaxy S21", categorias[0], fornecedores[0]));
            produtos.Add(new Produto("iPhone 13", categorias[0], fornecedores[1]));

            Console.WriteLine("Banco de dados inicializado com sucesso!");
        }

        static void ModuloCategoria(List<Categoria> categorias)
        {
            Console.Write("Digite o nome da nova categoria: ");
            string nome = Console.ReadLine();
            categorias.Add(new Categoria(nome));
            Console.WriteLine("Categoria cadastrada com sucesso!");
        }

        static void ModuloFornecedor(List<Fornecedor> fornecedores)
        {
            Console.Write("Digite o nome do fornecedor: ");
            string nome = Console.ReadLine();
            fornecedores.Add(new Fornecedor(nome));
            Console.WriteLine("Fornecedor cadastrado com sucesso!");
        }

        static void ModuloProduto(List<Produto> produtos, List<Categoria> categorias, List<Fornecedor> fornecedores)
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Escolha uma categoria para o produto:");
            ListarCategorias(categorias);
            int categoriaIndex = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Escolha um fornecedor para o produto:");
            ListarFornecedores(fornecedores);
            int fornecedorIndex = int.Parse(Console.ReadLine()) - 1;

            produtos.Add(new Produto(nome, categorias[categoriaIndex], fornecedores[fornecedorIndex]));
            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        static void ListarCategorias(List<Categoria> categorias)
        {
            Console.WriteLine("CATEGORIAS CADASTRADAS:");
            for (int i = 0; i < categorias.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {categorias[i].Nome}");
            }
        }

        static void ListarFornecedores(List<Fornecedor> fornecedores)
        {
            Console.WriteLine("FORNECEDORES CADASTRADOS:");
            for (int i = 0; i < fornecedores.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {fornecedores[i].Nome}");
            }
        }

        static void ListarProdutos(List<Produto> produtos)
        {
            Console.WriteLine("PRODUTOS CADASTRADOS:");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"Produto: {produto.Nome}, Categoria: {produto.Categoria.Nome}, Fornecedor: {produto.Fornecedor.Nome}");
            }
        }
    }
}

