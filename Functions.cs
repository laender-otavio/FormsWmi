using System.Data.SqlTypes;

namespace FormsWmi
{
  public static class Functions
  {
    public static void LimpaCampos(params object[] obj)
    {
      foreach (object objeto in obj)
      {
        try
        {
          Limpa((TextBox)objeto);
        }
        catch
        {
          Limpa((ComboBox)objeto);
        }
      }
    }
    public static void Limpa(TextBox textBox)
    {
      textBox.Text = "";
    }
    public static void Limpa(ComboBox comboBox)
    {
      comboBox.Text = "";
    }
    public static string ConvertData(string data)
    {
      DateTime Data = Convert.ToDateTime(data);
      return Data.ToString("dd/MM/yyyy");
    }
  }
}
