using Projeto_Integrador_Construção_do_Sistema.Controlle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Integrador_Construção_do_Sistema
{
    public partial class NewProdutos : Form
    {
        Produtos a = new Produtos();
        public NewProdutos()
        {
            InitializeComponent();
        }

        

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }

        private void buttonGravarGeral_Click(object sender, EventArgs e)
        {
            a.ID = int.Parse(textIDgeral.Text);
            a.Nome = textNomegeral.Text;
            
        }

        private void buttonEmitirRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
/*p.IDPEDIDO = int.Parse(textIdPedido.Text);
p.DESCRICAO = textDescriçao.Text;
p.VALOR = double.Parse(textValorpedido.Text);
dataGridView1.Rows.Add(new object[] { p.IDPEDIDO, p.DESCRICAO, p.VALOR });*/