
public class Maquina{

    public int Id {get;set;}
    public string Marca {get;set;}
    public string Modelo {get;set;}
    public List<Produto> Produtos = new List<Produto>();

    public string ExibirInformacoesM(){
        string infoM = $" Maquina: ID: {Id}, Marca: {Marca}, Modelo: {Modelo}";
        return infoM;
    }

    public void IniciarProducao(Produto produto){
        this.Produtos.Add(produto);
    }

     public List<Produto> GetProdutos(){
        return this.Produtos;
    }

}