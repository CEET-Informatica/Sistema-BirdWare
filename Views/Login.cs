using Projeto_Integrador_Construção_do_Sistema.Controlle;
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
    public partial class Login : Form
    {
        Usuario x = new Usuario();
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textUsuarioLogin.Text == x.Usuario && int.Parse(textSenhaLogin.Text) == x.Senha)
            {
                MessageBox.Show("Seja Bem Vindo(a)");
            }
            else
            {
                if (textUsuarioLogin.Text != null && textSenhaLogin.Text != null)
                    MessageBox.Show("Usuario ou Senha Incorreto");

            }
            this.Hide();
            Home f = new Home();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void buttonCadastrodeUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrodeUsuario f = new CadastrodeUsuario();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
