//Instanciar uma Industria
Industria LH = new Industria();
LH.Nome = "Industrias LH";
LH.Localizacao = "Curitiba";
LH.AnoFundacao = 2005;

//------------------------------------------------------------------
//Criando uma linha de producao e add na Industria
LinhaProducao Linha1 = new LinhaProducao();
Linha1.Numero = 1;
Linha1.Tipo = "Sapatos";
Linha1.Capacidade = 10;
//Adicionar LP na Industria
LH.adicionaLP(Linha1);

LinhaProducao Linha2 = new LinhaProducao();
Linha2.Numero = 2;
Linha2.Tipo = "Correntes";
Linha2.Capacidade = 50;
//Adicionar LP na Industria
LH.adicionaLP(Linha2);

//------------------------------------------------------------------
//Criacao das Maquinas
Maquina maquina1 = new Maquina();
maquina1.Id = 1;
maquina1.Marca = "Alpha";
maquina1.Modelo = "Costuradora de tenis";
//Adicionar Maquina na LP1

Linha1.adicionarMaquina(maquina1);

Maquina maquina2 = new Maquina();
maquina2.Id = 2;
maquina2.Marca = "Aomoto";
maquina2.Modelo = "Coladora de solas";
//Adicionar Maquina2 na LP1
Linha1.adicionarMaquina(maquina2);

Maquina maquina3 = new Maquina();
maquina3.Id = 3;
maquina3.Marca = "Vonder";
maquina3.Modelo = "Soldadora";
//Adicionar Maquina3 na LP2
Linha2.adicionarMaquina(maquina3);

Maquina maquina4 = new Maquina();
maquina4.Id = 4;
maquina4.Marca = "Tork";
maquina4.Modelo = "Argolas para Correntes";
//Adicionar Maquina4 na LP2
Linha2.adicionarMaquina(maquina4);

//------------------------------------------------------------------
//Criacao dos produtos
Produto produto1 = new Produto();
produto1.Nome = "Nike Air Force1";
produto1.Codigo = 10;
produto1.Preco = 550;
//Adicionar produto1 na maquina 1
maquina1.IniciarProducao(produto1);

Produto produto2 = new Produto();
produto2.Nome = "Nike Chuteira";
produto2.Codigo = 20;
produto2.Preco = 250;
//Adicionar produto2 na maquina 2
maquina2.IniciarProducao(produto2);

Produto produto3 = new Produto();
produto3.Nome = "Corrente prata";
produto3.Codigo = 30;
produto3.Preco = 350;
//Adicionar produto3 na maquina 3
maquina3.IniciarProducao(produto3);

Produto produto4 = new Produto();
produto4.Nome = "Corrente ouro";
produto4.Codigo = 40;
produto4.Preco = 1050;
//Adicionar produto4 na maquina 4
maquina4.IniciarProducao(produto4);

//------------------------------------------------------------------
//Exibicao das informacoes da industria
Console.WriteLine(LH.ExibirInformacoes());