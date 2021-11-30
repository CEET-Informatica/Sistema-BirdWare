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
    public partial class Login : Form
    {
        Banco x = new Banco();
        List<Banco> dados = new List<Banco>();
        //Usuario x = new Usuario();
        public Login()
        {
            InitializeComponent();
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textUsuarioLogin.Text == x.UsuarioNome || textSenhaLogin.Text == x.Senha)
            {
                this.Hide();
                Home f = new Home();
                f.Closed += (s, args) => this.Close();
                f.Show();
                MessageBox.Show("Seja Bem Vindo(a)");
            }
            else
            {
                    MessageBox.Show("Usuario ou Senha Incorreto");
            }

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
