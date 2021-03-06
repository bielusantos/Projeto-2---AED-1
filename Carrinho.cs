using System;
using System.Collections.Generic;

class Carrinho{
  private string Produto;
  private double Preco;
  private double ValorTotalDoCarrinho;
  public string[] ProdutosCarrinho;
  public List<string> ProdutoCliente = new List<string>();
  public List<double> PrecoProdutoCliente = new List<double>();
  public List<int> QuantidadeProdutoCliente = new List<int>();
  private double ValorPorProduto=0.0;
//Lista os produtos no carrinho

  public void CompraProduto (string Produto, double valor, int qtd){
    Console.Write("Produtos escolhidos -> {0} {1}", qtd, Produto);
    ProdutoCliente.Add(Produto);
    PrecoProdutoCliente.Add(valor);
    QuantidadeProdutoCliente.Add(qtd);
    ValorTotalDoCarrinho = (valor*qtd)+ValorTotalDoCarrinho;
    }

//Calcula o valor total de um item especifico
  public static void ProdutoPreco (double valor, int qtd){
    double PrecoTotalProduto;
    PrecoTotalProduto = valor*qtd;
    Console.WriteLine(PrecoTotalProduto);
    }
//Calcula o valor total de todos os itens no carrinho
  
  public double CarrinhoTotal (){
    
    Console.WriteLine("Estes são os itens, quantidades e preço dos produtos adquiridos:\n ");
    for(int i=0; i<ProdutoCliente.Count;i++){
      ValorPorProduto = QuantidadeProdutoCliente[i]*PrecoProdutoCliente[i];
      Console.WriteLine("{0} - {1} - R$ {2} - Total p/ produto R$ {3}", QuantidadeProdutoCliente[i],ProdutoCliente[i],PrecoProdutoCliente[i], ValorPorProduto);
      
    }
    
    Console.Write("\nE este é o total do carrinho ->R$ " );
    return ValorTotalDoCarrinho;
  }

}