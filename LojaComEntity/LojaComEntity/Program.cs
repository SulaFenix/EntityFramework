using LojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace LojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadesContext contexto = new EntidadesContext();

            decimal precoMinimo = 40;

            var busca = from p in contexto.Produtos 
                        where p.Categoria.Nome == "Roupas" && p.Preco > precoMinimo
                        orderby p.Preco
                        select p;

            IList<Produto> resultado = busca.ToList();

            foreach(var produto in resultado)
            {
                Console.WriteLine(produto.Nome + " - " + produto.Preco);
            }

            Console.ReadLine();
        }
    }
}
