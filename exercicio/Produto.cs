public class Produto{

    public string Nome {get;set;}
    public int Codigo {get;set;}
    public decimal Preco {get;set;}

    public string ExibirInformacoesP(){
        string infos = $"Nome do produto: {Nome}, Código: {Codigo}, Preço: R${Preco}";
        return infos;
    }

    public void AtualizarPreco(decimal novoPreco){
        Preco = novoPreco;
    }
}