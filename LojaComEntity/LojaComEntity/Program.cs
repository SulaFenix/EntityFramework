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
            //UsuarioDao dao = new UsuarioDao();
            //Usuario renan = dao.BuscaPorId(1);

            //Venda v = new Venda()
            //{
            //    Cliente = renan
            //};

            //Produto p = contexto.Produtos.FirstOrDefault(prod => prod.ID == 1);
            //Produto p2 = contexto.Produtos.FirstOrDefault(prod => prod.ID == 2);

            //ProdutoVenda pv = new ProdutoVenda()
            //{
            //    Venda = v,
            //    Produto = p
            //};

            //ProdutoVenda pv2 = new ProdutoVenda()
            //{
            //    Venda = v,
            //    Produto = p2
            //};

            //contexto.Vendas.Add(v);
            //contexto.ProdutoVenda.Add(pv);
            //contexto.ProdutoVenda.Add(pv2);
            //contexto.SaveChanges();

            Venda venda = contexto.Vendas
                .Include(v => v.ProdutoVenda)
                .ThenInclude(pv => pv.Produto)
                .FirstOrDefault(v => v.ID == 1);

            foreach(var pv in venda.ProdutoVenda)
            {
                Console.WriteLine(pv.Produto.Nome);
            }

            Console.ReadLine();
        }
    }
}
