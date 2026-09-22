namespace SistemaUsuarios
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        private void InitializeComponent()
        {
            panelMenu = new Panel();
            lblMenuTitulo = new Label();
            btnPerfil = new Button();
            btnSair = new Button();
            lblBemVindo = new Label();
            lblTitulo = new Label();
            lblTipo = new Label();

            panelMenu.SuspendLayout();
            SuspendLayout();

            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(30, 30, 46);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 701);
            panelMenu.TabIndex = 0;

            // 
            // lblMenuTitulo
            // 
            lblMenuTitulo.AutoSize = true;
            lblMenuTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMenuTitulo.ForeColor = Color.White;
            lblMenuTitulo.Location = new Point(55, 40);
            lblMenuTitulo.Name = "lblMenuTitulo";
            lblMenuTitulo.Size = new Size(110, 32);
            lblMenuTitulo.TabIndex = 0;
            lblMenuTitulo.Text = "SISTEMA";

            // 
            // btnPerfil
            // 
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Font = new Font("Segoe UI", 10F);
            btnPerfil.ForeColor = Color.White;
            btnPerfil.Location = new Point(20, 150);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(180, 45);
            btnPerfil.TabIndex = 1;
            btnPerfil.Text = "Meu Perfil";
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
            btnPerfil.BackColor = Color.FromArgb(45, 45, 65);
            btnPerfil.ForeColor = Color.White;
            btnPerfil.Visible = true;
            btnPerfil.Cursor = Cursors.Hand;

            btnPerfil.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(65, 65, 90);

            // 
            // btnSair
            // 
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 10F);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(20, 600);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(180, 45);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            btnSair.BackColor = Color.FromArgb(45, 45, 65);
            btnSair.ForeColor = Color.White;
            btnSair.Visible = true;
            btnSair.Cursor = Cursors.Hand;

            btnSair.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(65, 65, 90);

            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBemVindo.Location = new Point(300, 200);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(182, 41);
            lblBemVindo.TabIndex = 3;
            lblBemVindo.Text = "Bem-vindo!";

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.Location = new Point(300, 70);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(229, 54);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Dashboard";

            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 11F);
            lblTipo.Location = new Point(305, 270);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(143, 25);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo de usuário";

            // 
            // Adicionando os controles ao menu
            // 

            panelMenu.Controls.Add(lblMenuTitulo);
            panelMenu.Controls.Add(btnPerfil);
            panelMenu.Controls.Add(btnSair);
            panelMenu.Visible = true;
            btnPerfil.Visible = true;
            btnSair.Visible = true;

            panelMenu.ResumeLayout(true);

            btnPerfil.BringToFront();
            btnSair.BringToFront();

            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CausesValidation = false;
            ClientSize = new Size(1369, 701);
            Controls.Add(lblTipo);
            Controls.Add(lblBemVindo);
            Controls.Add(lblTitulo);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += FormDashboard_Load;

            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Label lblMenuTitulo;
        private Label lblBemVindo;
        private Button btnPerfil;
        private Button btnSair;
        private Label lblTitulo;
        private Label lblTipo;
    }
}