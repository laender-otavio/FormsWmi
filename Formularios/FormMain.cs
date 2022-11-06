namespace FormsWmi
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }
    private void BtnCadastroPaciente_Click(object sender, EventArgs e)
    {
      frmPaciente formPaciente = new();
      formPaciente.ShowDialog();
    }
    private void BtnCadastroAtendimento_Click(object sender, EventArgs e)
    {
      FormAtendimento formAtendimento = new();
      formAtendimento.ShowDialog();
    }
    private void BtnListarAtendimentos_Click(object sender, EventArgs e)
    {
      FormListaAtendimentos formListaAtendimentos = new();
      formListaAtendimentos.ShowDialog();
    }
  }
}
