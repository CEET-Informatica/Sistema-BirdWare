using Projeto_Integrador_Construção_do_Sistema.ConfigDb;
using Projeto_Integrador_Construção_do_Sistema.Controlle;
using Projeto_Integrador_Construção_do_Sistema.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador_Construção_do_Sistema
{
    public partial class NewProdutos : Form
    {
        Produtos a = new Produtos();
        Fornecedor b = new Fornecedor();
        Categoria c = new Categoria();
        private MyProdutosDBContext contex;

        public NewProdutos()
        {
            InitializeComponent();
            contex = new MyProdutosDBContext();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            BindingSource bi = new BindingSource();

            var query = from p in contex.Produtoses

                        select new { p.ID, p.Nome, p.Descricao, p.CategoriaId, p.Quantidade, p.Marca, p.UnidadedeMedidida, p.CustoMedio, p.ValorTotal};
            bi.DataSource = query.ToList();

            dataGridView1.DataSource = bi;
            dataGridView1.Refresh();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            var t = contex.Produtoses.Find((int)dataGridView1.SelectedCells[0].Value);
            contex.Produtoses.Remove(t);
            contex.SaveChanges();
            RefreshGrid();
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
            a.CategoriaId = int.Parse(textIdCategoria.Text);

            dataGridView1.Rows.Add(new object[] { a.ID, a.Nome, a.Descricao, c.Nome, a.Quantidade, a.Marca, a.UnidadedeMedidida, a.CustoMedio, a.ValorTotal });

            //Categoria
            c.ID = int.Parse(textIdCategoria.Text);
            c.Nome = textNomeCategoria.Text;
            c.Observacao = textDescCategoria.Text;

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
            if (buttonAtualizar.Text == "Atualizar")
            {
                textNomegeral.Text = dataGridView1.SelectedCells[1].Value.ToString();
                textDescGeral.Text = dataGridView1.SelectedCells[2].Value.ToString();
                textIdCategoria.Text = dataGridView1.SelectedCells[3].Value.ToString();
                textQuantidadeGeral.Text = dataGridView1.SelectedCells[4].Value.ToString();
                textMarcaGeral.Text = dataGridView1.SelectedCells[5].Value.ToString();
                textCustomedioGeral.Text = dataGridView1.SelectedCells[6].Value.ToString();
                textValortotalGeral.Text = dataGridView1.SelectedCells[7].Value.ToString();
                textFornecedorGeral.Text = dataGridView1.SelectedCells[8].Value.ToString();

                buttonAtualizar.Text = "Salvar";
            }
            else
            {
                var atualizarProdutos = contex.Produtoses.Find((int)dataGridView1.SelectedCells[0].Value);

                atualizarProdutos.Nome = textNomegeral.Text;
                atualizarProdutos.Descricao = textDescGeral.Text;
                atualizarProdutos.CategoriaId = int.Parse(textIdCategoria.Text);
                atualizarProdutos.Quantidade = int.Parse(textQuantidadeGeral.Text);
                atualizarProdutos.Marca = textMarcaGeral.Text;
                atualizarProdutos.CustoMedio = int.Parse(textCustomedioGeral.Text);
                atualizarProdutos.ValorTotal = int.Parse(textValortotalGeral.Text);


                contex.SaveChanges();
                RefreshGrid();

                buttonAtualizar.Text = "Atualizar";
                textNomegeral.Text = " ";
                textDescGeral.Text = " ";
                textIdCategoria.Text = " ";
                textQuantidadeGeral.Text = " ";
                textMarcaGeral.Text = " ";
                textCustomedioGeral.Text = " ";
                textValortotalGeral.Text = " ";
                textFornecedorGeral.Text = " ";
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (true)
            {
                var produtos = new Produtos()
                {
                    Nome = textNomegeral.Text,
                    Descricao = textDescGeral.Text,
                    CategoriaId = int.Parse(textIdCategoria.Text),
                    Quantidade = int.Parse(textQuantidadeGeral.Text),
                    Marca = textMarcaGeral.Text,
                    CustoMedio = int.Parse(textCustomedioGeral.Text),
                    ValorTotal = int.Parse(textValortotalGeral.Text)
                };

                contex.Produtoses.Add(produtos);

                contex.SaveChanges();

                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Você precisa inserir todos os dados");
            }
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
