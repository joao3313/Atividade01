namespace Atividade01
{
    using System;

    public class Produto
    {
        // Nome do produto
        public string nome;
        // Preço unitário do produto
        public double preco;
        // Quantidade disponível em estoque
        public int quantidade;
        // Categoria do produto
        public string categoria;
        // Nome do fornecedor
        public string fornecedor;

        // Construtor para inicializar o produto
        public Produto(string nome, double preco, int quantidade, string categoria, string fornecedor)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
            this.categoria = categoria;
            this.fornecedor = fornecedor;
        }

        // Método para vender uma quantidade específica do produto
        public void vender(int quantidadeVendida)
        {
            if (quantidade >= quantidadeVendida)
            {
                quantidade -= quantidadeVendida;
                Console.WriteLine($"Venda realizada de {nome}! {quantidade} unidades restantes.");
            }
            else
            {
                Console.WriteLine($"Estoque de {nome} insuficiente.");
            }
        }

        // Método para repor estoque do produto
        public void reporEstoque(int quantidadeReposicao)
        {
            quantidade += quantidadeReposicao;
            Console.WriteLine($"Foram adicionadas {quantidadeReposicao} unidades para {nome}. Novo estoque: {quantidade}");
        }

        // Método para calcular o valor total do estoque do produto
        public double calcularValorEstoque()
        {
            return quantidade * preco;
        }

        // Método para aplicar um desconto ao produto
        public void aplicarDesconto(double porcentagem)
        {
            preco -= preco * (porcentagem / 100);
            Console.WriteLine($"Novo preço do {nome} com desconto: {preco}");
        }

        // Método para exibir informações do produto
        public void mostrarInfo()
        {
            Console.WriteLine($"Produto: {nome}, Preço: {preco}, Quantidade: {quantidade}, Categoria: {categoria}, Fornecedor: {fornecedor}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Criando instâncias de produtos
            Produto p1 = new Produto("Notebook", 3500.00, 10, "Eletrônicos", "Tech Supplier");
            Produto p2 = new Produto("Mouse", 150.00, 50, "Periféricos", "Mouse Supplier");

            Console.WriteLine("\n--- Informações Iniciais ---");
            p1.mostrarInfo();
            p2.mostrarInfo();

            Console.WriteLine("\n--- Vendendo Produtos ---");
            p1.vender(30);
            p2.vender(15);

            Console.WriteLine("\n--- Repondo Estoque ---");
            p1.reporEstoque(5);
            p2.reporEstoque(20);

            Console.WriteLine("\n--- Aplicando Descontos ---");
            p1.aplicarDesconto(10);
            p2.aplicarDesconto(5);

            Console.WriteLine("\n--- Calculando Valor do Estoque ---");
            Console.WriteLine($"Valor total em estoque do {p1.nome}: {p1.calcularValorEstoque():C}");
            Console.WriteLine($"Valor total em estoque do {p2.nome}: {p2.calcularValorEstoque():C}");

            Console.WriteLine("\n--- Informações Finais ---");
            p1.mostrarInfo();
            p2.mostrarInfo();
        }
    }
}
