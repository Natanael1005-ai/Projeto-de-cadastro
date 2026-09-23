namespace SistemaUsuarios
{
    partial class Form1
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
            panelMarca = new Panel();
            lblMarca = new Label();
            lblSlogan = new Label();
            panelLogin = new Panel();
            label1 = new Label();
            lblSubtitulo = new Label();
            labelLoginTitulo = new Label();
            txtLogin = new TextBox();
            labelSenhaTitulo = new Label();
            txtSenha = new TextBox();
            btnEntrar = new Button();

            panelMarca.SuspendLayout();
            panelLogin.SuspendLayout();
            SuspendLayout();

            //
            // panelMarca
            //
            panelMarca.BackColor = Color.FromArgb(30, 30, 46);
            panelMarca.Dock = DockStyle.Left;
            panelMarca.Location = new Point(0, 0);
            panelMarca.Name = "panelMarca";
            panelMarca.Size = new Size(380, 560);
            panelMarca.TabIndex = 0;
            panelMarca.Controls.Add(lblMarca);
            panelMarca.Controls.Add(lblSlogan);

            //
            // lblMarca
            //
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblMarca.ForeColor = Color.White;
            lblMarca.Location = new Point(50, 230);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(200, 60);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "SISTEMA";

            //
            // lblSlogan
            //
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Segoe UI", 11F);
            lblSlogan.ForeColor = Color.FromArgb(180, 180, 200);
            lblSlogan.Location = new Point(52, 295);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(260, 25);
            lblSlogan.TabIndex = 1;
            lblSlogan.Text = "Gestão de usuários";

            //
            // panelLogin
            //
            panelLogin.BackColor = Color.White;
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(380, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(520, 560);
            panelLogin.TabIndex = 1;
            panelLogin.Controls.Add(btnEntrar);
            panelLogin.Controls.Add(txtSenha);
            panelLogin.Controls.Add(labelSenhaTitulo);
            panelLogin.Controls.Add(txtLogin);
            panelLogin.Controls.Add(labelLoginTitulo);
            panelLogin.Controls.Add(lblSubtitulo);
            panelLogin.Controls.Add(label1);

            //
            // label1 (título de boas-vindas)
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(30, 30, 46);
            label1.Location = new Point(70, 140);
            label1.Name = "label1";
            label1.Size = new Size(260, 45);
            label1.TabIndex = 0;
            label1.Text = "Bem-vindo!";
            label1.Click += label1_Click;

            //
            // lblSubtitulo
            //
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(120, 120, 130);
            lblSubtitulo.Location = new Point(72, 190);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(280, 23);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Entre com seu login e senha";

            //
            // labelLoginTitulo
            //
            labelLoginTitulo.AutoSize = true;
            labelLoginTitulo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            labelLoginTitulo.ForeColor = Color.FromArgb(90, 90, 100);
            labelLoginTitulo.Location = new Point(72, 250);
            labelLoginTitulo.Name = "labelLoginTitulo";
            labelLoginTitulo.Size = new Size(50, 20);
            labelLoginTitulo.TabIndex = 2;
            labelLoginTitulo.Text = "LOGIN";

            //
            // txtLogin
            //
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Font = new Font("Segoe UI", 11F);
            txtLogin.Location = new Point(72, 273);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(376, 32);
            txtLogin.TabIndex = 3;

            //
            // labelSenhaTitulo
            //
            labelSenhaTitulo.AutoSize = true;
            labelSenhaTitulo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            labelSenhaTitulo.ForeColor = Color.FromArgb(90, 90, 100);
            labelSenhaTitulo.Location = new Point(72, 325);
            labelSenhaTitulo.Name = "labelSenhaTitulo";
            labelSenhaTitulo.Size = new Size(55, 20);
            labelSenhaTitulo.TabIndex = 4;
            labelSenhaTitulo.Text = "SENHA";

            //
            // txtSenha
            //
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Segoe UI", 11F);
            txtSenha.Location = new Point(72, 348);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(376, 32);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;

            //
            // btnEntrar
            //
            btnEntrar.BackColor = Color.FromArgb(30, 30, 46);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 72);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(72, 410);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(376, 44);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click_1;

            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 560);
            Controls.Add(panelLogin);
            Controls.Add(panelMarca);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Sistema de Usuários";
            Load += Form1_Load;

            panelMarca.ResumeLayout(false);
            panelMarca.PerformLayout();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panelMarca;
        private Label lblMarca;
        private Label lblSlogan;
        private Panel panelLogin;
        private Label label1;
        private Label lblSubtitulo;
        private Label labelLoginTitulo;
        private TextBox txtLogin;
        private Label labelSenhaTitulo;
        private TextBox txtSenha;
        private Button btnEntrar;
    }
}