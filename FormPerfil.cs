using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaUsuarios
{
    public partial class FormPerfil : Form
    {
        private readonly Usuario usuario;

        public FormPerfil(Usuario usuarioLogado)
        {
            InitializeComponent();
            usuario = usuarioLogado;
        }

        private void FormPerfil_Load(object? sender, EventArgs e)
        {
            txtNome.Text = usuario.Nome;
            txtLogin.Text = usuario.Login;
            lblTipo.Text = usuario.Tipo;
        }

        private void bntSalvar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Digite seu nome.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Digite seu login.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Digite sua senha.");
                return;
            }

            // Guarda os valores atuais para restaurar caso o banco falhe
            string nomeAnterior = usuario.Nome;
            string loginAnterior = usuario.Login;
            string senhaAnterior = usuario.Senha;

            try
            {
                usuario.Nome = txtNome.Text.Trim();
                usuario.Login = txtLogin.Text.Trim();
                usuario.Senha = txtSenha.Text;

                UsuarioDAO dao = new UsuarioDAO();
                dao.AtualizaPerfil(usuario);

                MessageBox.Show(
                    "Dados atualizados com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
            }
            catch (Exception erro)
            {
                usuario.Nome = nomeAnterior;
                usuario.Login = loginAnterior;
                usuario.Senha = senhaAnterior;

                MessageBox.Show(
                    "Erro ao atualizar os dados:\n\n" + erro.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void bntCancelar_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        #region Designer

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            labelNome = new Label();
            txtNome = new TextBox();
            labelLogin = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            labelSenha = new Label();
            labelTipo = new Label();
            lblTipo = new Label();
            bntSalvar = new Button();
            bntCancelar = new Button();
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
            txtSenha.UseSystemPasswordChar = true;
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
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(592, 448);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(118, 20);
            labelTipo.TabIndex = 7;
            labelTipo.Text = "Tipo de Usuário";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(644, 493);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(0, 20);
            lblTipo.TabIndex = 8;
            // 
            // bntSalvar
            // 
            bntSalvar.Location = new Point(498, 548);
            bntSalvar.Name = "bntSalvar";
            bntSalvar.Size = new Size(94, 29);
            bntSalvar.TabIndex = 9;
            bntSalvar.Text = "Salvar";
            bntSalvar.UseVisualStyleBackColor = true;
            bntSalvar.Click += bntSalvar_Click;
            // 
            // bntCancelar
            // 
            bntCancelar.Location = new Point(690, 548);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.Size = new Size(94, 29);
            bntCancelar.TabIndex = 10;
            bntCancelar.Text = "Cancelar";
            bntCancelar.UseVisualStyleBackColor = true;
            bntCancelar.Click += bntCancelar_Click;
            // 
            // FormPerfil
            // 
            ClientSize = new Size(1373, 648);
            Controls.Add(bntCancelar);
            Controls.Add(bntSalvar);
            Controls.Add(lblTipo);
            Controls.Add(labelTipo);
            Controls.Add(labelSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(labelLogin);
            Controls.Add(txtNome);
            Controls.Add(labelNome);
            Controls.Add(lblTitulo);
            Name = "FormPerfil";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Meu Perfil";
            Load += FormPerfil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Label labelNome;
        private TextBox txtNome;
        private Label labelLogin;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label labelSenha;
        private Label labelTipo;
        private Label lblTipo;
        private Button bntSalvar;
        private Button bntCancelar;
        #endregion

    }
}