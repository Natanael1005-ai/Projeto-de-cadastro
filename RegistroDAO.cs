using System;
using System.Collections.Generic;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace SistemaUsuarios
{
    public class RegistroDAO
    {
        // Mesma conexao usada pelo UsuarioDAO.
        private FbConnection NovaConexao()
        {
            return Conexao.CriarConexao();
        }

        private static void Abrir(FbConnection con)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
        }

        public void Inserir(Registro r)
        {
            const string sql =
                "INSERT INTO REGISTROS (ID_USUARIO, DATA_REGISTRO, CATEGORIA, VALOR, DESCRICAO) " +
                "VALUES (@usuario, @data, @categoria, @valor, @descricao)";

            using (var con = NovaConexao())
            {
                Abrir(con);
                using (var cmd = new FbCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", r.IdUsuario);
                    cmd.Parameters.AddWithValue("@data", r.Data.Date);
                    cmd.Parameters.AddWithValue("@categoria", r.Categoria);
                    cmd.Parameters.AddWithValue("@valor", r.Valor);
                    cmd.Parameters.AddWithValue("@descricao", (object)r.Descricao ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Registro> ListarPorUsuario(int idUsuario)
        {
            const string sql =
                "SELECT ID, ID_USUARIO, DATA_REGISTRO, CATEGORIA, VALOR, DESCRICAO " +
                "FROM REGISTROS WHERE ID_USUARIO = @usuario " +
                "ORDER BY DATA_REGISTRO DESC, ID DESC";

            var lista = new List<Registro>();

            using (var con = NovaConexao())
            {
                Abrir(con);
                using (var cmd = new FbCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", idUsuario);
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            lista.Add(new Registro
                            {
                                Id = rd.GetInt32(0),
                                IdUsuario = rd.GetInt32(1),
                                Data = rd.GetDateTime(2),
                                Categoria = rd.GetString(3),
                                Valor = rd.GetDecimal(4),
                                Descricao = rd.IsDBNull(5) ? "" : rd.GetString(5)
                            });
                        }
                    }
                }
            }

            return lista;
        }

        // Filtra tambem pelo usuario: um usuario nunca apaga registro de outro.
        public void Excluir(int idRegistro, int idUsuario)
        {
            const string sql = "DELETE FROM REGISTROS WHERE ID = @id AND ID_USUARIO = @usuario";

            using (var con = NovaConexao())
            {
                Abrir(con);
                using (var cmd = new FbCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", idRegistro);
                    cmd.Parameters.AddWithValue("@usuario", idUsuario);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}