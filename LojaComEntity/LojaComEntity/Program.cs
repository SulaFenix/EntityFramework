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
            ProdutoDao dao = new ProdutoDao(contexto);

            var resultado = dao.BuscaPorNomePrecoNomeCategoria("Mouse", 50, null);

            foreach(var p in resultado)
            {
                Console.WriteLine(p.Nome);
            }

            Console.ReadLine();
        }
    }
}
