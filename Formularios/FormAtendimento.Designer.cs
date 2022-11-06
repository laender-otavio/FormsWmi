namespace FormsWmi
{
  partial class FormAtendimento
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
      this.DataAtendimento = new System.Windows.Forms.TextBox();
      this.CpfPaciente = new System.Windows.Forms.TextBox();
      this.DescricaoAtendimento = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.BtnSalvar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // DataAtendimento
      // 
      this.DataAtendimento.Location = new System.Drawing.Point(12, 146);
      this.DataAtendimento.Name = "DataAtendimento";
      this.DataAtendimento.Size = new System.Drawing.Size(156, 23);
      this.DataAtendimento.TabIndex = 0;
      // 
      // CpfPaciente
      // 
      this.CpfPaciente.Location = new System.Drawing.Point(174, 146);
      this.CpfPaciente.Name = "CpfPaciente";
      this.CpfPaciente.Size = new System.Drawing.Size(148, 23);
      this.CpfPaciente.TabIndex = 1;
      // 
      // DescricaoAtendimento
      // 
      this.DescricaoAtendimento.Location = new System.Drawing.Point(12, 200);
      this.DescricaoAtendimento.Multiline = true;
      this.DescricaoAtendimento.Name = "DescricaoAtendimento";
      this.DescricaoAtendimento.Size = new System.Drawing.Size(776, 143);
      this.DescricaoAtendimento.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 128);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(121, 15);
      this.label1.TabIndex = 3;
      this.label1.Text = "Data do Atendimento";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(174, 128);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(93, 15);
      this.label2.TabIndex = 4;
      this.label2.Text = "CPF do Paciente";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 182);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(148, 15);
      this.label3.TabIndex = 5;
      this.label3.Text = "Descrição do Atendimento";
      // 
      // BtnSalvar
      // 
      this.BtnSalvar.Location = new System.Drawing.Point(353, 377);
      this.BtnSalvar.Name = "BtnSalvar";
      this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
      this.BtnSalvar.TabIndex = 6;
      this.BtnSalvar.Text = "Cadastrar";
      this.BtnSalvar.UseVisualStyleBackColor = true;
      this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
      // 
      // FormAtendimento
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BtnSalvar);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.DescricaoAtendimento);
      this.Controls.Add(this.CpfPaciente);
      this.Controls.Add(this.DataAtendimento);
      this.Name = "FormAtendimento";
      this.Text = "FormAtendimento";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private TextBox DataAtendimento;
        private TextBox CpfPaciente;
        private TextBox DescricaoAtendimento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnSalvar;
    }
}