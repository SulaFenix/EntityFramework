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
            ManipuladorUsuario manipulador = new ManipuladorUsuario();
            Usuario vitor = new Usuario()
            {
                Nome = "Vitor",
                Senha = "123"
            };

            manipulador.Salva(vitor);

            Console.WriteLine("Salvou o usuário");
            Console.ReadLine();
        }
    }
}
