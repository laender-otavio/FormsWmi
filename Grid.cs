using System.Data;

namespace FormsWmi
{
  public static class Grid
  {
    public static void Monta(DataGridView grid, DataSet ds)
    {
      grid.ColumnCount = 4;
      grid.Columns[0].Name = "ID Atendimento";
      grid.Columns[1].Name = "CPF Paciente";
      grid.Columns[1].Width = 150;
      grid.Columns[2].Name = "Data do Atendimento";
      grid.Columns[2].Width = 150;
      grid.Columns[3].Name = "Descrição do Atendimento";
      grid.Columns[3].Width = 250;

      var Linhas = new List<string[]>();

      if (ds.Tables[0].Rows.Count > 0)
      {
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
          string? Id = ds.Tables[0].Rows[i]["Pk"].ToString();
          string? CpfPaciente = ds.Tables[0].Rows[i]["CpfPaciente"].ToString();
          string? DataAtendimento = ds.Tables[0].Rows[i]["DataAtendimento"].ToString();
          string? DescricaoAtendimento = ds.Tables[0].Rows[i]["DescricaoAtendimento"].ToString();

          string[] linha = new string[] { Id, CpfPaciente, Functions.ConvertData(DataAtendimento), DescricaoAtendimento };
          Linhas.Add(linha);
        }
        foreach (string[] LinhaArray in Linhas)
        {
          grid.Rows.Add(LinhaArray);
        }
      }
    }
  }
}
