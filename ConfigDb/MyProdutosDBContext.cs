using Projeto_Integrador_Construção_do_Sistema.Controlle;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Projeto_Integrador_Construção_do_Sistema.ConfigDb
{
    class MyProdutosDBContext: DbContext
    {
        public DbSet<Produtos> Produtoses { get; set; }
    }
}
