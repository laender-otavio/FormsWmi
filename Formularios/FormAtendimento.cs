namespace FormsWmi
{
  public partial class FormAtendimento : Form
  {
    public FormAtendimento()
    {
      InitializeComponent();
    }
    private void BtnSalvar_Click(object sender, EventArgs e)
    {
      Atendimento atendimento = new Atendimento(DataAtendimento.Text, CpfPaciente.Text, DescricaoAtendimento.Text);
      atendimento.Salvar(out bool Salvo);

      if (Salvo)
        Functions.LimpaCampos(DataAtendimento, CpfPaciente, DescricaoAtendimento);
    }
  }
}