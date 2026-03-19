namespace exemplo1
{
    internal class Produto
    {
        //Campos de classe
        public string nome;
        public double preco;
        public int quantidade;

        //Construtor
        public Produto(string nome, Double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        //Métodos
        public double Valor_Total_Em_Estoque()
        {
            return preco * quantidade;

        }

        public void Adicionar_Produtos(int qtd)
        {
            quantidade += qtd;
        }

        public void Remover_Produtos(int qnt)
        {
            quantidade -= qnt;
        }

        public string Dados_do_Produto()
        {
            return ($"Nome: {nome}, Preço: {preco}, Quantidade: {quantidade}," + 
                $"Total: {Valor_Total_Em_Estoque()}");
        }
    }
}
