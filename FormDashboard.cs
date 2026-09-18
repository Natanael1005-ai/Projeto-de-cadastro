using System;
using System.Windows.Forms;

namespace SistemaUsuarios
{
    public partial class FormDashboard : Form
    {
        private Usuario usuario;

        public FormDashboard(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;

            // Mostra os dados do usuário logado
            lblTitulo.Text = "Dashboard";
            lblBemVindo.Text = "Bem-vindo, " + usuario.Nome + "!";
            lblTipo.Text = "Tipo de usuário: " + usuario.Tipo;
        }

        // ==========================
        // BOTÃO MEU PERFIL
        // ==========================
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "DADOS DO USUÁRIO\n\n" +
                "Nome: " + usuario.Nome + "\n" +
                "Login: " + usuario.Login + "\n" +
                "Tipo: " + usuario.Tipo,

                "Meu Perfil",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // ==========================
        // BOTÃO SAIR
        // ==========================
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja realmente sair?",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Form1 login = new Form1();

                login.Show();

                this.Hide();
            }
        }
    }
}