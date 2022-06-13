using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    [System.Serializable]
    class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public Ebook (string nome, float preco,string autor)
        {
            this.nome = nome;
            this.autor = autor;
            this.preco = preco;
            
        }

        public void AdicionarEntrada()
        {
           
        }

        public void AdicionarSaida()
        {
            
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Nome: {preco}");
            Console.WriteLine($"Vendas  : {vendas}");
            Console.WriteLine("============================");
        }
    }
}
