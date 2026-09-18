using System;
using System.Windows.Forms;

namespace SistemaUsuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string login = txtLogin.Text;
                string senha = txtSenha.Text;

                if (string.IsNullOrWhiteSpace(login) ||
                    string.IsNullOrWhiteSpace(senha))
                {
                    MessageBox.Show(
                        "Digite o login e a senha.",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                UsuarioDAO dao = new UsuarioDAO();

                Usuario usuario = dao.FazerLogin(login, senha);

                if (usuario != null)
                {
                    MessageBox.Show(
                        "Login realizado com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Se for administrador
                    if (usuario.Tipo == "ADMIN")
                    {
                        FormAdmin formAdmin = new FormAdmin();

                        this.Hide();

                        formAdmin.ShowDialog();

                        this.Show();

                    }
                    else if (usuario.Tipo == "USUARIO")
                    {
                        FormDashboard dashboard = new FormDashboard(usuario);
                        dashboard.Show();

                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show(
                        "Login ou senha incorretos!",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(
                    "Erro ao acessar o banco:\n\n" + erro.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}