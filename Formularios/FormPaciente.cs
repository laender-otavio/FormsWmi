using System.Data.SqlClient;
using System.Data;

namespace FormsWmi
{
  public partial class frmPaciente : Form
  {
    public frmPaciente()
    {
      InitializeComponent();
    }
    private void BtnSalvar_Click(object sender, EventArgs e)
    {
      Paciente paciente = new(Cpf.Text, Nome.Text, DataNascimento.Text, Sexo.Text);
      paciente.Salvar(out bool Salvo);

      if (Salvo)
        Functions.LimpaCampos(Cpf, Nome, DataNascimento, Sexo);
    }
  }
}