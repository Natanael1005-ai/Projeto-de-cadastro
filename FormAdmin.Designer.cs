namespace SistemaUsuarios
{

    partial class FormAdmin
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelTopo = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            dgvUsuarios = new DataGridView();
            panelBotoes = new Panel();
            btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            btnEditar = new Guna.UI2.WinForms.Guna2Button();
            btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            bntCancelar = new Guna.UI2.WinForms.Guna2Button();
            panelTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panelBotoes.SuspendLayout();
            SuspendLayout();
            //
            // panelTopo
            //
            panelTopo.BackColor = Color.FromArgb(30, 30, 46);
            panelTopo.Dock = DockStyle.Top;
            panelTopo.Location = new Point(0, 0);
            panelTopo.Name = "panelTopo";
            panelTopo.Size = new Size(1368, 90);
            panelTopo.TabIndex = 0;
            panelTopo.Controls.Add(lblSubtitulo);
            panelTopo.Controls.Add(lblTitulo);
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(40, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(260, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Painel de Administração";
            //
            // lblSubtitulo
            //
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(180, 180, 200);
            lblSubtitulo.Location = new Point(42, 55);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(220, 23);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gerenciamento de usuários";
            //
            // dgvUsuarios
            //
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 250);
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(60, 60, 70);
            dgvUsuarios.ColumnHeadersHeight = 40;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsuarios.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvUsuarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 30, 46);
            dgvUsuarios.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 253);
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.FromArgb(230, 230, 235);
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(40, 110);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 32;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(1288, 490);
            dgvUsuarios.TabIndex = 1;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            //
            // panelBotoes
            //
            panelBotoes.Location = new Point(40, 615);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(1288, 55);
            panelBotoes.TabIndex = 2;
            panelBotoes.Controls.Add(btnCadastrar);
            panelBotoes.Controls.Add(btnEditar);
            panelBotoes.Controls.Add(btnExcluir);
            panelBotoes.Controls.Add(btnAtualizar);
            panelBotoes.Controls.Add(bntCancelar);
            //
            // btnCadastrar
            //
            btnCadastrar.BorderRadius = 8;
            btnCadastrar.CustomizableEdges = customizableEdges1;
            btnCadastrar.FillColor = Color.FromArgb(30, 30, 46);
            btnCadastrar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.HoverState.FillColor = Color.FromArgb(50, 50, 72);
            btnCadastrar.Location = new Point(0, 0);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCadastrar.Size = new Size(220, 48);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "+ Cadastrar";
            btnCadastrar.Click += btnCadastrar_Click;
            //
            // btnEditar
            //
            btnEditar.BorderRadius = 8;
            btnEditar.CustomizableEdges = customizableEdges3;
            btnEditar.FillColor = Color.White;
            btnEditar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(30, 30, 46);
            btnEditar.BorderColor = Color.FromArgb(210, 210, 220);
            btnEditar.BorderThickness = 1;
            btnEditar.HoverState.FillColor = Color.FromArgb(240, 240, 245);
            btnEditar.Location = new Point(240, 0);
            btnEditar.Name = "btnEditar";
            btnEditar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEditar.Size = new Size(220, 48);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            //
            // btnExcluir
            //
            btnExcluir.BorderRadius = 8;
            btnExcluir.CustomizableEdges = customizableEdges5;
            btnExcluir.FillColor = Color.FromArgb(200, 60, 60);
            btnExcluir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.HoverState.FillColor = Color.FromArgb(175, 45, 45);
            btnExcluir.Location = new Point(480, 0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnExcluir.Size = new Size(220, 48);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            //
            // btnAtualizar
            //
            btnAtualizar.BorderRadius = 8;
            btnAtualizar.CustomizableEdges = customizableEdges7;
            btnAtualizar.FillColor = Color.White;
            btnAtualizar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAtualizar.ForeColor = Color.FromArgb(30, 30, 46);
            btnAtualizar.BorderColor = Color.FromArgb(210, 210, 220);
            btnAtualizar.BorderThickness = 1;
            btnAtualizar.HoverState.FillColor = Color.FromArgb(240, 240, 245);
            btnAtualizar.Location = new Point(830, 0);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAtualizar.Size = new Size(200, 48);
            btnAtualizar.TabIndex = 3;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.Click += btnAtualizar_Click;
            //
            // bntCancelar
            //
            bntCancelar.BorderRadius = 8;
            bntCancelar.CustomizableEdges = customizableEdges9;
            bntCancelar.FillColor = Color.Transparent;
            bntCancelar.Font = new Font("Segoe UI", 9.5F);
            bntCancelar.ForeColor = Color.FromArgb(120, 120, 130);
            bntCancelar.HoverState.FillColor = Color.FromArgb(240, 240, 245);
            bntCancelar.Location = new Point(1060, 0);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            bntCancelar.Size = new Size(160, 48);
            bntCancelar.TabIndex = 4;
            bntCancelar.Text = "Fechar";
            bntCancelar.Click += bntCancelar_Click;
            //
            // FormAdmin
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1368, 697);
            Controls.Add(panelBotoes);
            Controls.Add(dgvUsuarios);
            Controls.Add(panelTopo);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciador";
            Load += FormAdmin_Load;
            panelTopo.ResumeLayout(false);
            panelTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panelBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopo;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private DataGridView dgvUsuarios;
        private Panel panelBotoes;
        private Guna.UI2.WinForms.Guna2Button btnCadastrar;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private Guna.UI2.WinForms.Guna2Button bntCancelar;
    }
}