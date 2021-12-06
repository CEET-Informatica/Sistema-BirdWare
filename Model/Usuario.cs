using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Integrador_Construção_do_Sistema.Controlle
{
    class Usuario
    {
        public int IDUsuario { get; set; }
        public string UsuarioNome { get; set; }
        public int Telefone { get; set; }
        public int Senha { get; set; }

        public int ProdutosId { get; set; }
        public Produtos produtos { get; set; }
    }
}
