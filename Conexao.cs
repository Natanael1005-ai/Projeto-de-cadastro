using FirebirdSql.Data.FirebirdClient;

public class Conexao
{
    public static FbConnection CriarConexao()
    {
        string connectionString =
            "DataSource=localhost;" +
            "Port=3050;" +
            "Database=C:/DB/EXE01.FDB;" +
            "User=SYSDBA;" +
            "Password=masterkey;";

        return new FbConnection(connectionString);
    }
}