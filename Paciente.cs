using System.Data.SqlClient;
using System.Data;

namespace FormsWmi
{
  public class Paciente
  {
    private string Cpf { get; set; }
    private string Nome { get; set; }
    private string DataNascimento { get; set; }
    private string Sexo { get; set; }

    SqlConnection con = Conexao.Con();
    SqlCommand? cmd;
    public Paciente(string Cpf, string Nome, string DataNascimento, string Sexo)
    {
      this.Cpf = Cpf;
      this.Nome = Nome;
      this.DataNascimento = DataNascimento;
      this.Sexo = Sexo;
    }
    public void Salvar(out bool Salvo)
    {
      Salvo = false;

      if (!Validador.ValidadorCpf(Cpf))
        MessageBox.Show("CPF Inválido, verifique o preenchimento");
      else
      {
        cmd = new SqlCommand("PcSalvaPaciente", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandTimeout = 0;

        cmd.Parameters.AddWithValue("@Cpf", Cpf);
        cmd.Parameters.AddWithValue("@Nome", Nome);
        cmd.Parameters.AddWithValue("@DataNascimento", DataNascimento);
        cmd.Parameters.AddWithValue("@Sexo", Sexo);

        try
        {
          con.Open();
          cmd.ExecuteNonQuery();
          MessageBox.Show("Paciente " + Nome + " cadastrado com Sucesso!");
          Salvo = true;
        }
        catch (SqlException erro)
        {
          MessageBox.Show("Erro: " + erro);
        }
        finally
        {
          con.Close();
        }
      }
    }
  }
}