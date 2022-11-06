namespace FormsWmi
{
  partial class FormMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.BtnCadastroPaciente = new System.Windows.Forms.Button();
      this.BtnCadastroAtendimento = new System.Windows.Forms.Button();
      this.BtnListarAtendimentos = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BtnCadastroPaciente
      // 
      this.BtnCadastroPaciente.Location = new System.Drawing.Point(91, 151);
      this.BtnCadastroPaciente.Name = "BtnCadastroPaciente";
      this.BtnCadastroPaciente.Size = new System.Drawing.Size(195, 113);
      this.BtnCadastroPaciente.TabIndex = 0;
      this.BtnCadastroPaciente.Text = "Cadastro de Pacientes";
      this.BtnCadastroPaciente.UseVisualStyleBackColor = true;
      this.BtnCadastroPaciente.Click += new System.EventHandler(this.BtnCadastroPaciente_Click);
      // 
      // BtnCadastroAtendimento
      // 
      this.BtnCadastroAtendimento.Location = new System.Drawing.Point(291, 151);
      this.BtnCadastroAtendimento.Name = "BtnCadastroAtendimento";
      this.BtnCadastroAtendimento.Size = new System.Drawing.Size(195, 113);
      this.BtnCadastroAtendimento.TabIndex = 1;
      this.BtnCadastroAtendimento.Text = "Cadastro de Atendimento";
      this.BtnCadastroAtendimento.UseVisualStyleBackColor = true;
      this.BtnCadastroAtendimento.Click += new System.EventHandler(this.BtnCadastroAtendimento_Click);
      // 
      // BtnListarAtendimentos
      // 
      this.BtnListarAtendimentos.Location = new System.Drawing.Point(491, 151);
      this.BtnListarAtendimentos.Name = "BtnListarAtendimentos";
      this.BtnListarAtendimentos.Size = new System.Drawing.Size(195, 113);
      this.BtnListarAtendimentos.TabIndex = 2;
      this.BtnListarAtendimentos.Text = "Lista de Atendimentos";
      this.BtnListarAtendimentos.UseVisualStyleBackColor = true;
      this.BtnListarAtendimentos.Click += new System.EventHandler(this.BtnListarAtendimentos_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BtnListarAtendimentos);
      this.Controls.Add(this.BtnCadastroAtendimento);
      this.Controls.Add(this.BtnCadastroPaciente);
      this.Name = "FormMain";
      this.Text = "Formulário Principal";
      this.ResumeLayout(false);

    }

        #endregion

        private Button BtnCadastroPaciente;
        private Button BtnCadastroAtendimento;
        private Button BtnListarAtendimentos;
    }
}