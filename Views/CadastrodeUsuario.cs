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
        
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            


            
        }
    }
}
