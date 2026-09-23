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

            // Aba "Meus Dados": dashboard do usuario logado
            tabDados.Controls.Add(new UcMeusDados(usuario.Id));
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
            // Cores do sistema
            Color corPrincipal = Color.FromArgb(30, 30, 46);
            Color corHover = Color.FromArgb(50, 50, 72);
            Color corTexto = Color.FromArgb(30, 30, 46);
            Color corSecundaria = Color.FromArgb(120, 120, 130);
            Color corFundo = Color.White;
            Color corBorda = Color.FromArgb(220, 220, 230);

            // Componentes
            tabControl = new TabControl();
            tabPerfil = new TabPage();
            tabDados = new TabPage();

            panelMarca = new Panel();
            lblMarca = new Label();
            lblSlogan = new Label();

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

            tabControl.SuspendLayout();
            tabPerfil.SuspendLayout();
            panelMarca.SuspendLayout();
            SuspendLayout();

            //
            // panelMarca - Painel lateral
            //
            panelMarca.BackColor = corPrincipal;
            panelMarca.Dock = DockStyle.Left;
            panelMarca.Name = "panelMarca";
            panelMarca.Size = new Size(280, 650);
            panelMarca.Controls.Add(lblMarca);
            panelMarca.Controls.Add(lblSlogan);

            //
            // lblMarca
            //
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblMarca.ForeColor = Color.White;
            lblMarca.Location = new Point(35, 250);
            lblMarca.Name = "lblMarca";
            lblMarca.Text = "SISTEMA";

            //
            // lblSlogan
            //
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Segoe UI", 10.5F);
            lblSlogan.ForeColor = Color.FromArgb(180, 180, 200);
            lblSlogan.Location = new Point(38, 305);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Text = "Gestão de usuários";

            //
            // tabControl
            //
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 10F);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(20, 8);
            tabControl.Controls.Add(tabPerfil);
            tabControl.Controls.Add(tabDados);

            //
            // tabPerfil
            //
            tabPerfil.BackColor = corFundo;
            tabPerfil.Controls.Add(lblTitulo);
            tabPerfil.Controls.Add(labelNome);
            tabPerfil.Controls.Add(txtNome);
            tabPerfil.Controls.Add(labelLogin);
            tabPerfil.Controls.Add(txtLogin);
            tabPerfil.Controls.Add(labelSenha);
            tabPerfil.Controls.Add(txtSenha);
            tabPerfil.Controls.Add(labelTipo);
            tabPerfil.Controls.Add(lblTipo);
            tabPerfil.Controls.Add(bntSalvar);
            tabPerfil.Controls.Add(bntCancelar);
            tabPerfil.Name = "tabPerfil";
            tabPerfil.Text = "Meu Perfil";
            tabPerfil.UseVisualStyleBackColor = false;

            //
            // tabDados
            //
            tabDados.BackColor = corFundo;
            tabDados.Name = "tabDados";
            tabDados.Text = "Meus Dados";
            tabDados.UseVisualStyleBackColor = false;

            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = corTexto;
            lblTitulo.Location = new Point(65, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Text = "Meu Perfil";

            //
            // labelNome
            //
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelNome.ForeColor = Color.FromArgb(90, 90, 100);
            labelNome.Location = new Point(70, 115);
            labelNome.Name = "labelNome";
            labelNome.Text = "NOME COMPLETO";

            //
            // txtNome
            //
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 11F);
            txtNome.Location = new Point(70, 140);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(430, 32);
            txtNome.TabIndex = 0;

            //
            // labelLogin
            //
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelLogin.ForeColor = Color.FromArgb(90, 90, 100);
            labelLogin.Location = new Point(70, 195);
            labelLogin.Name = "labelLogin";
            labelLogin.Text = "LOGIN";

            //
            // txtLogin
            //
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Font = new Font("Segoe UI", 11F);
            txtLogin.Location = new Point(70, 220);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(430, 32);
            txtLogin.TabIndex = 1;

            //
            // labelSenha
            //
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelSenha.ForeColor = Color.FromArgb(90, 90, 100);
            labelSenha.Location = new Point(70, 275);
            labelSenha.Name = "labelSenha";
            labelSenha.Text = "SENHA";

            //
            // txtSenha
            //
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Segoe UI", 11F);
            txtSenha.Location = new Point(70, 300);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(430, 32);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;

            //
            // labelTipo
            //
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTipo.ForeColor = Color.FromArgb(90, 90, 100);
            labelTipo.Location = new Point(70, 360);
            labelTipo.Name = "labelTipo";
            labelTipo.Text = "TIPO DE USUÁRIO";

            //
            // lblTipo
            //
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTipo.ForeColor = corPrincipal;
            lblTipo.Location = new Point(70, 385);
            lblTipo.Name = "lblTipo";
            lblTipo.Text = "";

            //
            // bntSalvar
            //
            bntSalvar.BackColor = corPrincipal;
            bntSalvar.Cursor = Cursors.Hand;
            bntSalvar.FlatStyle = FlatStyle.Flat;
            bntSalvar.FlatAppearance.BorderSize = 0;
            bntSalvar.FlatAppearance.MouseOverBackColor = corHover;
            bntSalvar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            bntSalvar.ForeColor = Color.White;
            bntSalvar.Location = new Point(70, 455);
            bntSalvar.Name = "bntSalvar";
            bntSalvar.Size = new Size(205, 45);
            bntSalvar.TabIndex = 3;
            bntSalvar.Text = "Salvar alterações";
            bntSalvar.UseVisualStyleBackColor = false;
            bntSalvar.Click += bntSalvar_Click;

            //
            // bntCancelar
            //
            bntCancelar.BackColor = Color.FromArgb(235, 235, 242);
            bntCancelar.Cursor = Cursors.Hand;
            bntCancelar.FlatStyle = FlatStyle.Flat;
            bntCancelar.FlatAppearance.BorderSize = 0;
            bntCancelar.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(215, 215, 225);
            bntCancelar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            bntCancelar.ForeColor = corPrincipal;
            bntCancelar.Location = new Point(295, 455);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.Size = new Size(205, 45);
            bntCancelar.TabIndex = 4;
            bntCancelar.Text = "Cancelar";
            bntCancelar.UseVisualStyleBackColor = false;
            bntCancelar.Click += bntCancelar_Click;

            //
            // FormPerfil
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = corFundo;
            ClientSize = new Size(1050, 650);

            // Adiciona primeiro o conteúdo e depois o painel lateral
            Controls.Add(tabControl);
            Controls.Add(panelMarca);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = true;
            Name = "FormPerfil";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Meu Perfil - Sistema de Usuários";

            Load += FormPerfil_Load;

            panelMarca.ResumeLayout(false);
            panelMarca.PerformLayout();

            tabControl.ResumeLayout(false);
            tabPerfil.ResumeLayout(false);
            tabPerfil.PerformLayout();

            ResumeLayout(false);
        }

        private Panel panelMarca;
        private Label lblMarca;
        private Label lblSlogan;

        private TabControl tabControl;
        private TabPage tabPerfil;
        private TabPage tabDados;

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

