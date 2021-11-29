
namespace Projeto_Integrador_Construção_do_Sistema
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textSenhaLogin = new System.Windows.Forms.TextBox();
            this.textUsuarioLogin = new System.Windows.Forms.TextBox();
            this.buttonCadastrodeUsuario = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(103, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(103, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // textSenhaLogin
            // 
            this.textSenhaLogin.Location = new System.Drawing.Point(159, 57);
            this.textSenhaLogin.Name = "textSenhaLogin";
            this.textSenhaLogin.PasswordChar = '*';
            this.textSenhaLogin.Size = new System.Drawing.Size(100, 23);
            this.textSenhaLogin.TabIndex = 3;
            // 
            // textUsuarioLogin
            // 
            this.textUsuarioLogin.Location = new System.Drawing.Point(159, 27);
            this.textUsuarioLogin.Name = "textUsuarioLogin";
            this.textUsuarioLogin.Size = new System.Drawing.Size(100, 23);
            this.textUsuarioLogin.TabIndex = 4;
            // 
            // buttonCadastrodeUsuario
            // 
            this.buttonCadastrodeUsuario.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonCadastrodeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrodeUsuario.Location = new System.Drawing.Point(3, 180);
            this.buttonCadastrodeUsuario.Name = "buttonCadastrodeUsuario";
            this.buttonCadastrodeUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrodeUsuario.TabIndex = 5;
            this.buttonCadastrodeUsuario.Text = "Cadastrar";
            this.buttonCadastrodeUsuario.UseVisualStyleBackColor = false;
            this.buttonCadastrodeUsuario.Click += new System.EventHandler(this.buttonCadastrodeUsuario_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogin.Location = new System.Drawing.Point(128, 96);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 28);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Caso não seja registrado:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCyan;
            this.pictureBox1.Image = global::Projeto_Integrador_Construção_do_Sistema.Properties.Resources.logoBD;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(269, 210);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonCadastrodeUsuario);
            this.Controls.Add(this.textUsuarioLogin);
            this.Controls.Add(this.textSenhaLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSenhaLogin;
        private System.Windows.Forms.TextBox textUsuarioLogin;
        private System.Windows.Forms.Button buttonCadastrodeUsuario;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

