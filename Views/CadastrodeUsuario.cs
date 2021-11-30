using Projeto_Integrador_Construção_do_Sistema.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Integrador_Construção_do_Sistema
{
    public partial class CadastrodeUsuario : Form
    {
        Banco x = new Banco();
        List<Banco> dados = new List<Banco>();
        public CadastrodeUsuario()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
        public void CarregarDados()
        {
            
            x.UsuarioNome = textNome.Text;
            x.Telefone = maskedtextTelefone.Text;
            x.Senha = textSenhaCadastro.Text;
            x.Senha = textConfirmaSenha.Text;
            dados.Add(x);
        }
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            CarregarDados();


            if (x.SalvarDados(dados, @"C:/Bd/BdBanco.Joson"))
            {
                MessageBox.Show("Dados cadastrados com sucesso!");
            }
        }
    }
}
