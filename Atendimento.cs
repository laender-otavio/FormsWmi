using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace FormsWmi
{
  public class Atendimento
  {
    private string DataAtendimento { get; set; }
    private string CpfPaciente { get; set; }
    private string DescricaoAtendimento { get; set; }

    SqlConnection con = Conexao.Con();
    SqlCommand? cmd;
    public Atendimento(string DataAtendimento, string CpfPaciente, string DescricaoAtendimento)
    {
      this.DataAtendimento = DataAtendimento;
      this.CpfPaciente = CpfPaciente;
      this.DescricaoAtendimento = DescricaoAtendimento;
    }
    public void Salvar(out bool Salvo)
    {
      Salvo = false;

      string? IdAtentimento = "0";

      if (!Validador.ValidaVinculoAtendimento(CpfPaciente))
        MessageBox.Show("CPF inválido ou não Cadastrado");
      else
      {
        cmd = new SqlCommand("PcSalvaAtendimento", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandTimeout = 0;

        cmd.Parameters.AddWithValue("@IdAtendimento", IdAtentimento).Direction = ParameterDirection.InputOutput;
        cmd.Parameters.AddWithValue("@CpfPaciente", CpfPaciente);
        cmd.Parameters.AddWithValue("@DataAtendimento", DataAtendimento);
        cmd.Parameters.AddWithValue("@DescricaoAtendimento", DescricaoAtendimento);

        try
        {
          con.Open();
          cmd.ExecuteNonQuery();
          IdAtentimento = cmd.Parameters["@IdAtendimento"].Value.ToString();
          MessageBox.Show("Atentimento com ID: " + IdAtentimento + " cadastrado com Sucesso!");
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
