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
        Fornecedor b = new Fornecedor();
        public NewProdutos()
        {
            InitializeComponent();
        }

        

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }

        private void buttonGravarGeral_Click(object sender, EventArgs e)
        {

            //geral
            a.ID = int.Parse(textIDgeral.Text);
            a.Nome = textNomegeral.Text;
            a.Descricao = textDescGeral.Text;
            a.Quantidade = int.Parse(textQuantidadeGeral.Text);
            a.Marca = textMarcaGeral.Text;
            a.UnidadedeMedidida = comboUDMGeral.Text;
            a.CustoMedio = int.Parse(textCustomedioGeral.Text);
            a.ValorTotal = int.Parse(textValortotalGeral.Text);
            a.IDFornc = int.Parse(textIDForncGeral.Text);

            dataGridView1.Rows.Add(new object[] { a.ID, a.Nome, a.Descricao, a.NomeCategoria, a.Quantidade, a.Marca, a.UnidadedeMedidida, a.CustoMedio, a.ValorTotal });

            //Categoria
            a.IDCategoria = int.Parse(textIdCategoria.Text);
            a.NomeCategoria = textNomeCategoria.Text;
            a.ObservacaoCategoria = textDescCategoria.Text;

            //Fornecedor
            b.ID = int.Parse(textIDForn.Text);
            b.Nome = textNomeForn.Text;
            b.CNPJ = int.Parse(textCNPJForn.Text);
            b.Endereco = textEnderecoForn.Text;
            b.Telefone1 = int.Parse(maskedTelefone1Forn.Text);
            b.Telefone2 = int.Parse(maskedTelefone2Forn.Text);

            dataGridView2.Rows.Add(new object[] { b.ID, b.Nome, b.CNPJ, b.Endereco, b.Telefone1, b.Telefone2 });
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

        private void buttonSalvarFornecedor_Click(object sender, EventArgs e)
        {
            //Fornecedor

            b.ID = int.Parse(textIDForn.Text);
            b.Nome = textNomeForn.Text;
            b.CNPJ = int.Parse(textCNPJForn.Text);
            b.Endereco = textEnderecoForn.Text;
            b.Telefone1 = int.Parse(maskedTelefone1Forn.Text);
            b.Telefone2 = int.Parse(maskedTelefone2Forn.Text);

            dataGridView1.Rows.Add(new object[] { b.ID, b.Nome, b.CNPJ, b.Endereco, b.Telefone1, b.Telefone2 });
        }
    }
}
