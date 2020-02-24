using System;
using System.Collections.Generic;

namespace LocadoraFilmes{
//CRIAÇÃO DA CLASSE CLIENTE COM SEUS DEVIDOS ATRIBUTOS
    public class Cliente{

			public List<Locacao> locacoes = new List<Locacao>();
            public int id_cliente;
            public String nome;
            public String dt_nasc;
            public String cpf;
            public int dias_pdevolucao;
            public int filmeslocados;
//CRIADO O CONSTRUTOR DA CLASSE CLIENTE
        public Cliente(int id_cliente, String nome, String dt_nasc, String cpf, int dias_pdevolucao ){
            this.id_cliente = id_cliente;
            this.nome = nome;
            this.dt_nasc = dt_nasc;
            this.cpf = cpf;
            this.dias_pdevolucao = dias_pdevolucao;
            this.filmeslocados = 0;
        }

//MÉTODO MOSTRANDO A  QUANTIDADE DE FILMES LOCADOS
	    public int QtdFimesCliente(int filmeslocados) {
		return this.filmeslocados = filmeslocados;
	    }
//IMPRIMINDO DADOS DO CLIENTE
	    public void mostrarCliente() {
		    Console.WriteLine("CLIENTE: \n");
		    Console.WriteLine("ID DO CLIENTE: " + id_cliente);
		    Console.WriteLine("NOME: " + nome);
		    Console.WriteLine("DATA DE NASCIMENTO: " + dt_nasc);
		    Console.WriteLine("CPF: " + cpf);
		    Console.WriteLine("DIAS PARA DEVOLUÇÃO: " + dias_pdevolucao);
		    Console.WriteLine("QUANTIDADE DE LOCAÇÕES: " + filmeslocados);
	    }
//ADICIONANDO AS LOCAÇÕES DOS FILMES
	    public void adicionarLocacao(Locacao locacao) {
		    this.locacoes.Add(locacao);
	    }
//LISTANDO AS LOCAÇÕES
	    public int getLocacoes() {
		    int qtd = 0;

		    foreach (Locacao locacao in this.locacoes) {
			    foreach (Filmes filme in locacao.filmes) {
				    qtd++;
			    }
		    }
		    return qtd;
	    }
    }
}