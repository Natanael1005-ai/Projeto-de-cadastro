namespace SistemaUsuarios
{
    partial class FormCadastro
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtNome;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private ComboBox cmbTipo;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label lblNome;
        private Label lblLogin;
        private Label lblSenha;
        private Label lblTipo;

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
            txtNome = new TextBox();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            cmbTipo = new ComboBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            lblNome = new Label();
            lblLogin = new Label();
            lblSenha = new Label();
            lblTipo = new Label();
            label1 = new Label();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(486, 82);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(342, 27);
            txtNome.TabIndex = 1;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(486, 175);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(342, 27);
            txtLogin.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(486, 293);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(342, 27);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Items.AddRange(new object[] { "USUARIO", "ADMIN" });
            cmbTipo.Location = new Point(486, 413);
            cmbTipo.Margin = new Padding(3, 4, 3, 4);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(342, 28);
            cmbTipo.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(486, 474);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(160, 53);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(668, 474);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 53);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(632, 43);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(636, 133);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(49, 20);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(632, 248);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(52, 20);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(643, 341);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(42, 20);
            lblTipo.TabIndex = 6;
            lblTipo.Text = "Tipo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(596, 552);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 10;
            label1.Text = "Já possui conta?\r\n";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(608, 591);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(94, 29);
            btnEntrar.TabIndex = 11;
            btnEntrar.Text = "Faça login";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 694);
            Controls.Add(btnEntrar);
            Controls.Add(label1);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipo);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCadastro";
            Text = "Cadastro de Usuário";
            Load += FormCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Button btnEntrar;
    }
}