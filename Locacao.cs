using System;
using System.Collections.Generic;

namespace LocadoraFilmes{
//CRIAÇÃO DA CLASSE LOCACÃO COM SEUS DEVIDOS ATRIBUTOS
    public class Locacao{

		public List<Filmes> filmes = new List<Filmes>();
        public int id_locacao = 0;
        public Cliente cliente;
        public String dt_locacao;
        public String dt_devolucao;
        public double vlr_total;
//CRIANDO O CONSTRUTOR DA CLASSE LOCAÇÃO
        public Locacao(int idLoc, Cliente cliente) {

		    this.id_locacao = idLoc;
		    this.cliente = cliente;
		    this.cliente.adicionarLocacao(this);
	    }
//ADICIONADO OS FILMES
	    public void adicionarFilme(Filmes filme) {
		    this.filmes.Add(filme);
	    }
//MÉTODO MONSTRANDO O VALOR TOTAL DAS LOCAÇÕES
	    public double preco_locacoes() {
		    double total = 0;
		    foreach (Filmes filme in filmes) {
			    total += filme.valor_locacao;
		    }
		    return total;
	    }
//MÉTODO MONSTRANDO A QUANTIDADE DE FILMES LOCADOS
	    public int qtd_filmeslocados() {
		    return this.filmes.Count;
	    }
//CALCULO PARA MOSTRAR A DATA DE DEVOLUÇÃO
	    public String calculo_dtdevolucao() {
		    DateTime dataAtual = DateTime.Now;
		    return dataAtual.AddDays(cliente.dias_pdevolucao).ToString("dddd, dd MMMM yyyy");
	    }
    }
}