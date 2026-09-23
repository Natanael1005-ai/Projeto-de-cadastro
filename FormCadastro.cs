using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SistemaUsuarios
{
    public partial class FormCadastro : Form
    {
        
        private readonly FormAdmin? admin;
        private readonly Usuario? usuarioEditando;

        // Construtor para CADASTRO
        public FormCadastro(FormAdmin admin)
        {
            InitializeComponent();
            this.admin = admin;
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

        // Validação dos campos
        private bool CamposValidos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Digite o nome.");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Digite o login.");
                txtLogin.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Digite a senha.");
                txtSenha.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbTipo.Text))
            {
                MessageBox.Show("Selecione o tipo de usuário.");
                cmbTipo.Focus();
                return false;
            }

            return true;
        }

        // BOTÃO SALVAR
        private void btnSalvar_Click(object? sender, EventArgs e)
        {
            if (!CamposValidos())
                return;

            try
            {
                UsuarioDAO dao = new UsuarioDAO();

                if (usuarioEditando != null)
                {
                    // ============================
                    // EDIÇÃO
                    // ============================
                    // Usa uma cópia para só alterar o objeto original
                    // depois que o banco confirmar a gravação
                    Usuario atualizado = new Usuario
                    {
                        Id = usuarioEditando.Id,
                        Nome = txtNome.Text.Trim(),
                        Login = txtLogin.Text.Trim(),
                        Senha = txtSenha.Text,
                        Tipo = cmbTipo.Text
                    };

                    dao.AtualizaPerfil(atualizado);

                    usuarioEditando.Nome = atualizado.Nome;
                    usuarioEditando.Login = atualizado.Login;
                    usuarioEditando.Senha = atualizado.Senha;
                    usuarioEditando.Tipo = atualizado.Tipo;

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
                        Nome = txtNome.Text.Trim(),
                        Login = txtLogin.Text.Trim(),
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
        private void btnCancelar_Click(object? sender, EventArgs e)
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
        private void btnEntrar_Click(object? sender, EventArgs e)
        {// 1. Cria e mostra a nova janela
            Form1 form = new Form1();
            form.Show();

            // 2. Fecha todas as janelas anteriores
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                var janela = Application.OpenForms[i];

                // Garante que não vai fechar a janela que acabou de abrir
                if (janela != form)
                {
                    janela.Close();
                }
            }
        }

        // CARREGAMENTO DO FORMULÁRIO
        private void FormCadastro_Load(object? sender, EventArgs e)
        {
        }
    }
}