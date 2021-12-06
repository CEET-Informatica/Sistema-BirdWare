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
        
        List<Usuario> dados = new List<Usuario>();
        Usuario x = new Usuario();
        public Login()
        {
            InitializeComponent();
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
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
