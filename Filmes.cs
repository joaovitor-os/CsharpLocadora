using System;

namespace LocadoraFilmes{
//CRIAÇÃO DA CLASSE FILMES COM SEUS DEVIDOS ATRIBUTOS
    public class Filmes{

        public int id_filmes;
        public String nome_filme;
        public String dt_lancamento;
        public String sinopse;
        public double valor_locacao;
        public int estoque;
        public int locado ;
//CRIADO O CONSTRUTOR DA CLASSE FILMES
        public Filmes(int id_filmes, String nome_filme, String dt_lancamento, String sinopse, double valor_locacao, int estoque){
            this.id_filmes = id_filmes;
            this.nome_filme = nome_filme;
            this.dt_lancamento = dt_lancamento;
            this.sinopse = sinopse; 
            this.valor_locacao = valor_locacao;
            this.estoque = estoque;
            this.locado = 0;
        }
//MÉTODO MONSTRANDO A QUANTIDADE DE LOCAÇÕES
        public void filmeLocado() {
            this.estoque -= 1;
            this.locado += 1;
        }
//IMPRIMINDO DADOS DO FILME
        public void mostrarFilme() {
            Console.WriteLine("FILME: \n");
            Console.WriteLine("ID DO FILME: " + id_filmes);
            Console.WriteLine("FILME: " + nome_filme);
            Console.WriteLine("DATA DE LANÇAMENTO: " + dt_lancamento);
            Console.WriteLine("SINOPSE: " + sinopse);
            Console.WriteLine("VALOR DA LOCAÇÃO: R$ " + valor_locacao);
            Console.WriteLine("QUANTIDADE EM ESTOQUE: " + estoque);
            Console.WriteLine("QUANTIDADE DE LOCAÇÕES REALIZADAS: " + locado);
        }
    }
}