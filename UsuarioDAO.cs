using System.Collections.Generic;
using FirebirdSql.Data.FirebirdClient;


public class UsuarioDAO
{
    public Usuario? FazerLogin(string login, string senha)
    {
        using (FbConnection conexao = Conexao.CriarConexao())
        {
            conexao.Open();

            string sql = @"
                SELECT ID, NOME, LOGIN, SENHA, TIPO
                FROM USUARIOS
                WHERE LOGIN = @LOGIN
                AND SENHA = @SENHA
            ";

            using (FbCommand comando = new FbCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@LOGIN", login);
                comando.Parameters.AddWithValue("@SENHA", senha);

                using (FbDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Usuario
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Login = reader.GetString(2),
                            Senha = reader.GetString(3),
                            Tipo = reader.GetString(4)
                        };
                    }
                }
            }
        }

        return null;
    }
    public List<Usuario> ListarUsuarios()
    {
        List<Usuario> usuarios = new List<Usuario>();

        using (FbConnection conexao = Conexao.CriarConexao())
        {
            conexao.Open();

            string sql = @"
            SELECT ID, NOME, LOGIN, SENHA, TIPO
            FROM USUARIOS
            ORDER BY ID
        ";

            using (FbCommand comando = new FbCommand(sql, conexao))
            using (FbDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        Login = reader.GetString(2),
                        Senha = reader.GetString(3),
                        Tipo = reader.GetString(4)
                    };

                    usuarios.Add(usuario);
                }
            }
        }

        return usuarios;
    }
    public void CadastrarUsuario(Usuario usuario)
    {
        using (FbConnection conexao = Conexao.CriarConexao())
        {
            conexao.Open();

            string sql = @"
            INSERT INTO USUARIOS
            (NOME, LOGIN, SENHA, TIPO)
            VALUES
            (@NOME, @LOGIN, @SENHA, @TIPO)
        ";

            using (FbCommand comando = new FbCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@NOME", usuario.Nome);
                comando.Parameters.AddWithValue("@LOGIN", usuario.Login);
                comando.Parameters.AddWithValue("@SENHA", usuario.Senha);
                comando.Parameters.AddWithValue("@TIPO", usuario.Tipo);

                comando.ExecuteNonQuery();
            }
        }
    }
    public void AtualizaPerfil(Usuario usuario)
    {
        using (FbConnection conexao = Conexao.CriarConexao())
        {
            conexao.Open();

            string sql = @"
            UPDATE USUARIOS
            SET NOME = @NOME,
                LOGIN = @LOGIN,
                SENHA = @SENHA,
                TIPO = @TIPO
            WHERE ID = @ID
        ";

            using (FbCommand comando = new FbCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@NOME", usuario.Nome);
                comando.Parameters.AddWithValue("@LOGIN", usuario.Login);
                comando.Parameters.AddWithValue("@SENHA", usuario.Senha);
                comando.Parameters.AddWithValue("@TIPO", usuario.Tipo);
                comando.Parameters.AddWithValue("@ID", usuario.Id);

                comando.ExecuteNonQuery();
            }
        }
    }
    public void ExcluirUsuario(int id)
    {
        using (FbConnection conexao = Conexao.CriarConexao())
        {
            conexao.Open();

            string sql = @"
            DELETE FROM USUARIOS
            WHERE ID = @ID
        ";

            using (FbCommand comando = new FbCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@ID", id);

                comando.ExecuteNonQuery();
            }
        }
    }
    public void CancelarOperação()
    {

    }
}

