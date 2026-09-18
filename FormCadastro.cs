using System;
using System.Windows.Forms;

namespace SistemaUsuarios
{
    public partial class FormCadastro : Form
    {
        FormAdmin admin = null;
        private Usuario? usuarioEditando;

        // Construtor para CADASTRO
        public FormCadastro(FormAdmin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        // Construtor para EDIÇÃO
        public FormCadastro(Usuario usuario)
        {
            InitializeComponent();

            usuarioEditando = usuario;

            txtNome.Text = usuario.Nome;
            txtLogin.Text = usuario.Login;
            txtSenha.Text = usuario.Senha;
            cmbTipo.Text = usuario.Tipo;
        }

        // BOTÃO SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDAO dao = new UsuarioDAO();

                // ============================
                // EDIÇÃO
                // ============================
                if (usuarioEditando != null)
                {
                    usuarioEditando.Nome = txtNome.Text;
                    usuarioEditando.Login = txtLogin.Text;
                    usuarioEditando.Senha = txtSenha.Text;
                    usuarioEditando.Tipo = cmbTipo.Text;

                    dao.AtualizarUsuario(usuarioEditando);

                    MessageBox.Show(
                        "Usuário atualizado com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    // ============================
                    // CADASTRO
                    // ============================
                    Usuario novoUsuario = new Usuario
                    {
                        Nome = txtNome.Text,
                        Login = txtLogin.Text,
                        Senha = txtSenha.Text,
                        Tipo = cmbTipo.Text
                    };

                    dao.CadastrarUsuario(novoUsuario);

                    MessageBox.Show(
                        "Usuário cadastrado com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                // Fecha o formulário depois de salvar
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(
                    "Erro ao salvar usuário:\n\n" + erro.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // BOTÃO CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja cancelar esta operação?",
                "Cancelar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // BOTÃO ENTRAR
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        // CARREGAMENTO DO FORMULÁRIO
        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}