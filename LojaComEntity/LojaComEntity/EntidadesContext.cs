using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaComEntity.Entidades;
using System.Configuration;

namespace LojaComEntity
{
    public class EntidadesContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["lojaConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(stringConexao);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
