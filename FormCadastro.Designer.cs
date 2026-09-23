namespace SistemaUsuarios
{
    partial class FormCadastro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelMarca = new Panel();
            lblMarca = new Label();
            lblSlogan = new Label();
            panelForm = new Panel();
            lblTitulo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            btnEntrar = new Button();
            panelMarca.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            //
            // panelMarca
            //
            panelMarca.BackColor = Color.FromArgb(30, 30, 46);
            panelMarca.Dock = DockStyle.Left;
            panelMarca.Location = new Point(0, 0);
            panelMarca.Name = "panelMarca";
            panelMarca.Size = new Size(340, 720);
            panelMarca.TabIndex = 0;
            panelMarca.Controls.Add(lblMarca);
            panelMarca.Controls.Add(lblSlogan);
            //
            // lblMarca
            //
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblMarca.ForeColor = Color.White;
            lblMarca.Location = new Point(45, 310);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(190, 55);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "SISTEMA";
            //
            // lblSlogan
            //
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Segoe UI", 11F);
            lblSlogan.ForeColor = Color.FromArgb(180, 180, 200);
            lblSlogan.Location = new Point(47, 370);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(220, 25);
            lblSlogan.TabIndex = 1;
            lblSlogan.Text = "Cadastro de usuário";
            //
            // panelForm
            //
            panelForm.BackColor = Color.White;
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(340, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(660, 720);
            panelForm.TabIndex = 1;
            panelForm.Controls.Add(btnEntrar);
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(btnCancelar);
            panelForm.Controls.Add(btnSalvar);
            panelForm.Controls.Add(cmbTipo);
            panelForm.Controls.Add(lblTipo);
            panelForm.Controls.Add(txtSenha);
            panelForm.Controls.Add(lblSenha);
            panelForm.Controls.Add(txtLogin);
            panelForm.Controls.Add(lblLogin);
            panelForm.Controls.Add(txtNome);
            panelForm.Controls.Add(lblNome);
            panelForm.Controls.Add(lblTitulo);
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 46);
            lblTitulo.Location = new Point(60, 60);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(280, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Dados do usuário";
            //
            // lblNome
            //
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNome.ForeColor = Color.FromArgb(90, 90, 100);
            lblNome.Location = new Point(62, 130);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(52, 20);
            lblNome.TabIndex = 1;
            lblNome.Text = "NOME";
            //
            // txtNome
            //
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 11F);
            txtNome.Location = new Point(62, 153);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(460, 32);
            txtNome.TabIndex = 2;
            //
            // lblLogin
            //
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLogin.ForeColor = Color.FromArgb(90, 90, 100);
            lblLogin.Location = new Point(62, 205);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(48, 20);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "LOGIN";
            //
            // txtLogin
            //
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Font = new Font("Segoe UI", 11F);
            txtLogin.Location = new Point(62, 228);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(460, 32);
            txtLogin.TabIndex = 4;
            //
            // lblSenha
            //
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSenha.ForeColor = Color.FromArgb(90, 90, 100);
            lblSenha.Location = new Point(62, 280);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(55, 20);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "SENHA";
            //
            // txtSenha
            //
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Segoe UI", 11F);
            txtSenha.Location = new Point(62, 303);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(460, 32);
            txtSenha.TabIndex = 6;
            txtSenha.UseSystemPasswordChar = true;
            //
            // lblTipo
            //
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTipo.ForeColor = Color.FromArgb(90, 90, 100);
            lblTipo.Location = new Point(62, 355);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(40, 20);
            lblTipo.TabIndex = 7;
            lblTipo.Text = "TIPO";
            //
            // cmbTipo
            //
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 10.5F);
            cmbTipo.Items.AddRange(new object[] { "USUARIO", "ADMIN" });
            cmbTipo.Location = new Point(62, 378);
            cmbTipo.Margin = new Padding(3, 4, 3, 4);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(460, 30);
            cmbTipo.TabIndex = 8;
            //
            // btnSalvar
            //
            btnSalvar.BorderRadius = 8;
            btnSalvar.CustomizableEdges = customizableEdges1;
            btnSalvar.FillColor = Color.FromArgb(30, 30, 46);
            btnSalvar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.HoverState.FillColor = Color.FromArgb(50, 50, 72);
            btnSalvar.Location = new Point(62, 440);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSalvar.Size = new Size(222, 50);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            //
            // btnCancelar
            //
            btnCancelar.BorderRadius = 8;
            btnCancelar.CustomizableEdges = customizableEdges3;
            btnCancelar.FillColor = Color.White;
            btnCancelar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(30, 30, 46);
            btnCancelar.BorderColor = Color.FromArgb(210, 210, 220);
            btnCancelar.BorderThickness = 1;
            btnCancelar.HoverState.FillColor = Color.FromArgb(240, 240, 245);
            btnCancelar.Location = new Point(300, 440);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancelar.Size = new Size(222, 50);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F);
            label1.ForeColor = Color.FromArgb(120, 120, 130);
            label1.Location = new Point(62, 520);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 11;
            label1.Text = "Já possui conta?";
            //
            // btnEntrar
            //
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold | FontStyle.Underline);
            btnEntrar.ForeColor = Color.FromArgb(30, 30, 46);
            btnEntrar.Location = new Point(196, 515);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(90, 29);
            btnEntrar.TabIndex = 12;
            btnEntrar.Text = "Faça login";
            btnEntrar.TextAlign = ContentAlignment.MiddleLeft;
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            //
            // FormCadastro
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 720);
            Controls.Add(panelForm);
            Controls.Add(panelMarca);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Usuário";
            Load += FormCadastro_Load;
            panelMarca.ResumeLayout(false);
            panelMarca.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panelMarca;
        private Label lblMarca;
        private Label lblSlogan;
        private Panel panelForm;
        private Label lblTitulo;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblLogin;
        private TextBox txtLogin;
        private Label lblSenha;
        private TextBox txtSenha;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Label label1;
        private Button btnEntrar;
    }
}