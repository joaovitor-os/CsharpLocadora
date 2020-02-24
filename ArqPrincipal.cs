using System;

namespace LocadoraFilmes{

    class ArqPrincipal{
        static void Main(string[] args){
            Console.WriteLine("LOCADORA DE FILMES \n");
//ADICIONADO CLIENTES
            Cliente cliente1 = new Cliente(1,"Gionisio","23/03/1977","111.111111-11",3);
            Cliente cliente2 = new Cliente(2,"Frederico","02/06/1981","222.222.222-22",3);
            Cliente cliente3 = new Cliente(3,"Jubileu","17/08/1969","333.333.333-33",3);
            Cliente cliente4 = new Cliente(4,"Florentina","14/13/1972","444.444.444-44",3);
            Cliente cliente5 = new Cliente(5,"Antonieta","27/11/1983","555.555.555-55",3);
//ADICIONANDO FILMES
            Filmes filmes1 = new Filmes(11111,"Coringa","2019","Drama",4.99,5);
            Filmes filmes2 = new Filmes(22222,"Vingadores: Ultimato","2019","Ação",4.99,5);
            Filmes filmes3 = new Filmes(11122,"Rocky III","1982","drama",3.50,3);
            Filmes filmes4 = new Filmes(11133,"Creed","2015","drama",4.20,4);
            Filmes filmes5 = new Filmes(33333,"O lobo de wall street","2013","drama/comédia",3.99,2);
            Filmes filmes6 = new Filmes(22233,"Batman: O Cavaleiro das Trevas","2008","ação",3.50,3);
            Filmes filmes7 = new Filmes(44444,"De Volta para o Futuro","1985","ficção cinentifica",3.99,3);
            Filmes filmes8 = new Filmes(44455,"Star Wars: Uma Nova Esperança","1977","ficção cientifica",3.99,3);
            Filmes filmes9 = new Filmes(55555,"Toy Story","1995","animação",3.99,3);
            Filmes filmes10 = new Filmes(11144,"Clube da Luta","1996","drama",2.99,2);

//CRIANDO SWITCH PARA PODER ESCOLHER O CLIENTE E RECEBER SUAS LOCAÇÕES
        	int id_cliente = 0;
			Locacao locacao;
			do {
				Console.WriteLine("\n INFORME O ID DO CLIENTE: \n");
            	String entrada = Console.ReadLine();
				id_cliente = Convert.ToInt32(entrada);
				switch (id_cliente) {
				case 1:
					cliente1.mostrarCliente(); //IMPRIMIR CLIENTE "1"
					locacao = new Locacao(01, cliente4); //ADICIONANDO LOCAÇÃO "1"
					filmes2.mostrarFilme(); // IMPRIMIR  FILMES DO CLIENTE "1"
					filmes8.mostrarFilme(); 
					filmes9.mostrarFilme();
					locacao.adicionarFilme(filmes2); // ADICIONAR FILMES DO CLIENTE "1"
					locacao.adicionarFilme(filmes8); 
					locacao.adicionarFilme(filmes9);
					Console.WriteLine("PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.preco_locacoes());
					Console.WriteLine("DATA DE DEVOLUÇÃO: " + locacao.calculo_dtdevolucao());
					Console.WriteLine("QUANTIDADE TOTAL DE FILMES LOCADOS: " + locacao.qtd_filmeslocados());
					break;
				case 2:
					cliente2.mostrarCliente(); //IMPRIMIR CLIENTE "2"
					locacao = new Locacao(02, cliente2); //ADICIONANDO LOCAÇÃO "2"
					filmes3.mostrarFilme(); // IMPRIMIR  FILMES DO CLIENTE "2"
					filmes4.mostrarFilme();
					locacao.adicionarFilme(filmes3); // ADICIONAR FILMES DO CLIENTE "2"
					locacao.adicionarFilme(filmes4);
					Console.WriteLine("PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.preco_locacoes());
					Console.WriteLine("DATA DE DEVOLUÇÃO: " + locacao.calculo_dtdevolucao());
					Console.WriteLine("QUANTIDADE TOTAL DE FILMES LOCADOS: " + locacao.qtd_filmeslocados());
					break;
				case 3:
					cliente3.mostrarCliente(); //IMPRIMIR CLIENTE "3"
					locacao = new Locacao(03, cliente3); //ADICIONANDO LOCAÇÃO "3"
					filmes1.mostrarFilme(); // IMPRIMIR  FILMES DO CLIENTE "3"
					filmes5.mostrarFilme();
					filmes6.mostrarFilme();
					filmes10.mostrarFilme();
					locacao.adicionarFilme(filmes1); // ADICIONAR FILMES DO CLIENTE "3"
					locacao.adicionarFilme(filmes5);
					locacao.adicionarFilme(filmes6);
					locacao.adicionarFilme(filmes10);
					Console.WriteLine("PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.preco_locacoes());
					Console.WriteLine("DATA DE DEVOLUÇÃO: " + locacao.calculo_dtdevolucao());
					Console.WriteLine("QUANTIDADE TOTAL DE FILMES LOCADOS: " + locacao.qtd_filmeslocados());
					break;
				case 4:
					cliente4.mostrarCliente(); //IMPRIMIR CLIENTE "4"
					locacao = new Locacao(04, cliente1); //ADICIONANDO LOCAÇÃO "4"
					filmes4.mostrarFilme(); // IMPRIMIR  FILMES DO CLIENTE "4"
					filmes9.mostrarFilme();
					locacao.adicionarFilme(filmes4); // ADICIONAR FILMES DO CLIENTE "4"
					locacao.adicionarFilme(filmes9);
					Console.WriteLine("PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.preco_locacoes());
					Console.WriteLine("DATA DE DEVOLUÇÃO: " + locacao.calculo_dtdevolucao());
					Console.WriteLine("QUANTIDADE TOTAL DE FILMES LOCADOS: " + locacao.qtd_filmeslocados());
					break;
				case 5:
					cliente5.mostrarCliente(); //IMPRIMIR CLIENTE "5"
					locacao = new Locacao(05, cliente5); //ADICIONANDO LOCAÇÃO "5"
					filmes1.mostrarFilme(); // IMPRIMIR  FILMES DO CLIENTE "5"
					filmes5.mostrarFilme();
					filmes10.mostrarFilme();
					locacao.adicionarFilme(filmes1); // ADICIONAR FILMES DO CLIENTE "5"
					locacao.adicionarFilme(filmes5);
					locacao.adicionarFilme(filmes10);
					Console.WriteLine("PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.preco_locacoes());
					Console.WriteLine("DATA DE DEVOLUÇÃO: " + locacao.calculo_dtdevolucao());
					Console.WriteLine("QUANTIDADE TOTAL DE FILMES LOCADOS: " + locacao.qtd_filmeslocados());
					break;
				}
			} while (id_cliente <= 5);    
        }
    }
}