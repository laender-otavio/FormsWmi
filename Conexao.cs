using System.Data.SqlClient;

namespace FormsWmi
{
  public static class Conexao
  {
    public static SqlConnection Con()
    {
      SqlConnection con;

      string StringConexao;
      StringConexao = @"Data Source=NOTEBOOK-TAVINH\SQLLOCAL;Initial Catalog=WmiTesteDevs;User ID=WmiLogon;Password=123";
      con = new SqlConnection(StringConexao);

      return con;
    }
  }
}