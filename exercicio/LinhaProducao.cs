public class LinhaProducao{

    public int Numero {get;set;}
    public string Tipo {get;set;}
    public int Capacidade {get;set;}
    public List<Maquina> Maquinas = new List<Maquina>();  
    
    public string ExibirDetalhes(){
        string infoLP = $"Numero: {Numero}, Tipo de produto: {Tipo}, Capacidade de producao: {Capacidade}";
        return infoLP;
    }

    public void adicionarMaquina(Maquina maquina){
         this.Maquinas.Add(maquina);
    }

     public List<Maquina> GetMaquinas(){
        return this.Maquinas;
    }
}