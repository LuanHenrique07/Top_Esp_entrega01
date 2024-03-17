public class Industria
{
public string Nome {get;set;}
    public string Localizacao {get;set;}
    public int AnoFundacao {get;set;}
    public List<LinhaProducao> LinhasProducoes = new List<LinhaProducao>();  

    public string ExibirInformacoes(){
        string informacoes = $"Nome: {Nome}, Localização: {Localizacao}, Ano de Fundação: {AnoFundacao}\n";
        informacoes += "Linhas de Produção:\n";
    
        foreach (var linhaProducao in LinhasProducoes)
        {
        informacoes += linhaProducao.ExibirDetalhes() + "\n";
        foreach (var maquina in linhaProducao.GetMaquinas())
            {
                informacoes += maquina.ExibirInformacoesM() + "\n";
                foreach (var produto in maquina.GetProdutos())
                {
                    informacoes += produto.ExibirInformacoesP() + "\n";;
                }
            }    
        }
        return informacoes;
    }

    public void adicionaLP(LinhaProducao linhaProducao){
        this.LinhasProducoes.Add(linhaProducao);
    }
    public List<LinhaProducao> GetLinhaProducoes(){
        return this.LinhasProducoes;
    }
}

