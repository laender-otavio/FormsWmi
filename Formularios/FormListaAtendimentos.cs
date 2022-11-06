using System.Data.SqlClient;
using System.Data;
namespace FormsWmi
{
  public partial class FormListaAtendimentos : Form
  {
    SqlConnection con = Conexao.Con();
    SqlCommand? cmd;
    SqlDataAdapter? da;
    DataSet? ds;
    public FormListaAtendimentos()
    {
      InitializeComponent();
    }
    private void FormListaAtendimentos_Load(object sender, EventArgs e)
    {
      cmd = new SqlCommand("Select * From Atendimento", con);
      cmd.CommandType = CommandType.Text;
      cmd.CommandTimeout = 0;

      da = new SqlDataAdapter(cmd);
      ds = new DataSet();
      try
      {
        da.Fill(ds);
        Grid.Monta(DataGridView, ds);
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
