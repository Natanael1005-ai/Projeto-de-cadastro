using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaUsuarios
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            try
            {
                UsuarioDAO dao = new UsuarioDAO();

                List<Usuario> usuarios = dao.ListarUsuarios();

                dgvUsuarios.DataSource = usuarios;
            }
            catch (Exception erro)
            {
                MessageBox.Show(
                    "Erro ao carregar usuários:\n\n" + erro.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro(this);

            formCadastro.ShowDialog();

            CarregarUsuarios();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show(
                    "Selecione um usuário para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int id = Convert.ToInt32(
                dgvUsuarios.CurrentRow.Cells["ID"].Value
            );

            string nome = dgvUsuarios.CurrentRow.Cells["NOME"].Value.ToString();
            string login = dgvUsuarios.CurrentRow.Cells["LOGIN"].Value.ToString();
            string senha = dgvUsuarios.CurrentRow.Cells["SENHA"].Value.ToString();
            string tipo = dgvUsuarios.CurrentRow.Cells["TIPO"].Value.ToString();

            Usuario usuario = new Usuario
            {
                Id = id,
                Nome = nome,
                Login = login,
                Senha = senha,
                Tipo = tipo
            };

            FormCadastro formCadastro = new FormCadastro(usuario);

            formCadastro.ShowDialog();

            CarregarUsuarios();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show(
                    "Selecione um usuário para excluir.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int id = Convert.ToInt32(
                dgvUsuarios.CurrentRow.Cells["ID"].Value
            );

            string nome = dgvUsuarios.CurrentRow.Cells["NOME"].Value.ToString();
            string login = dgvUsuarios.CurrentRow.Cells["LOGIN"].Value.ToString();

            DialogResult resultado = MessageBox.Show(
                $"Deseja realmente excluir o usuário \"{nome}\" (login: {login})?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
                return;

            try
            {
                UsuarioDAO dao = new UsuarioDAO();
                dao.ExcluirUsuario(id);

                MessageBox.Show(
                    "Usuário excluído com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CarregarUsuarios();
            }
            catch (Exception erro)
            {
                MessageBox.Show(
                    "Erro ao excluir usuário:\n\n" + erro.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }

}
