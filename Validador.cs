using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace FormsWmi
{
  public static class Validador
  {
    static SqlConnection con = Conexao.Con();
    static SqlCommand cmd;
    static SqlDataAdapter da;
    static DataSet ds;
    public static bool ValidadorCpf(string Cpf)
    {
      Cpf = Cpf.Trim();
      Cpf = Cpf.Replace(".", "").Replace("-", "");

      if (Cpf.Length != 11) //Verificando o Tamanho do CPF
        return false;

      for (int i = 0; i <= 10; i++) //Verificando se todos os Números são Inteiros
      {
        if (!char.IsDigit(Cpf[i]))
          return false;
      }

      for (int i = 0; i < 10; i++) //Verificando se são Números Repetidos
      {
        string StringRepetido = string.Concat(Enumerable.Repeat(i.ToString(), 11));

        if (Cpf == StringRepetido)
          return false;
      }

      #region "Verificação do Décimo Dígito"
      int[] MultiplicadorInicial = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
      string CpfTemp = Cpf.Substring(0, 9);
      int Soma = 0;

      for (int i = 0; i < 9; i++)
        Soma += int.Parse(CpfTemp[i].ToString()) * MultiplicadorInicial[i];

      int Resto;

      Resto = (Soma * 10) % 11;

      if (Resto == 10)
        Resto = 0;

      if (Resto.ToString() != Cpf[9].ToString())
        return false;
      #endregion

      #region "Verificação do Último Dígito"
      int[] SegundoMultiplicador = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
      CpfTemp = Cpf.Substring(0, 10);
      Soma = 0;
      Resto = 0;

      for (int i = 0; i < 10; i++)
        Soma += int.Parse(CpfTemp[i].ToString()) * SegundoMultiplicador[i];

      Resto = (Soma * 10) % 11;

      if (Resto == 10)
        Resto = 0;

      if (Resto.ToString() != Cpf[10].ToString())
        return false;
      #endregion

      return true;
    }
    public static bool ValidaVinculoAtendimento(string Cpf)
    {
      if (!ValidadorCpf(Cpf))
        return false;

      string? Valor = "";

      cmd = new SqlCommand("Select Top 1 Pk From Pacientes Where (Cpf = @Cpf)", con);
      cmd.CommandType = CommandType.Text;
      cmd.CommandTimeout = 0;
      cmd.Parameters.AddWithValue("@Cpf", Cpf);

      da = new SqlDataAdapter(cmd);
      ds = new DataSet();
      try
      {
        da.Fill(ds);

        if (ds.Tables[0].Rows.Count > 0)
          Valor = ds.Tables[0].Rows[0]["Pk"].ToString();
        else
          Valor = "";
      }
      catch (SqlException erro)
      {
        MessageBox.Show("Erro: " + erro);
      }
      finally
      {
        con.Close();
      }

      return Valor != "";
    }
  }
}
