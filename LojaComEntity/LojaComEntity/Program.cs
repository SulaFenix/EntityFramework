using LojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioDao dao = new UsuarioDao();
            Usuario renan = dao.BuscaPorId(1);

            renan.Nome = "Renan Saggio";
            dao.SaveChanges();

            Console.ReadLine();
        }
    }
}
