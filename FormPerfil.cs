using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaUsuarios
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            labelNome = new Label();
            txtNome = new TextBox();
            labelLogin = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            labelSenha = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(607, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(75, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Meu Perfil";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(618, 88);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(585, 140);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 2;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(622, 206);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(46, 20);
            labelLogin.TabIndex = 3;
            labelLogin.Text = "Login";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(585, 261);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(125, 27);
            txtLogin.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(585, 375);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 27);
            txtSenha.TabIndex = 5;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(622, 320);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(49, 20);
            labelSenha.TabIndex = 6;
            labelSenha.Text = "Senha";
            // 
            // Form2
            // 
            ClientSize = new Size(1373, 648);
            Controls.Add(labelSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(labelLogin);
            Controls.Add(txtNome);
            Controls.Add(labelNome);
            Controls.Add(lblTitulo);
            Name = "Form2";
            ResumeLayout(false);
            PerformLayout();

        }

        private Label lblTitulo;
        private Label labelNome;
        private Label labelLogin;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label labelSenha;
        private TextBox txtNome;
    }
}
