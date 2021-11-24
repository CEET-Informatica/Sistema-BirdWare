﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Integrador_Construção_do_Sistema.Controlle
{
    class Produtos
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public string Marca { get; set; }
        public string UnidadedeMedidida { get; set; }
        public int CustoMedio { get; set; }
        public int ValorTotal { get; set; }
        public int IDFornc { get; set; }
        //Categoria
        public int IDCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public string ObservacaoCategoria { get; set; }
    }
}
