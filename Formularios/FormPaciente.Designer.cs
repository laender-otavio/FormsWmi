namespace FormsWmi
{
  partial class frmPaciente
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.Nome = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.Cpf = new System.Windows.Forms.TextBox();
      this.DataNascimento = new System.Windows.Forms.TextBox();
      this.Sexo = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.BtnSalvar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Nome
      // 
      this.Nome.Location = new System.Drawing.Point(12, 220);
      this.Nome.Name = "Nome";
      this.Nome.Size = new System.Drawing.Size(265, 23);
      this.Nome.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 204);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(40, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Nome";
      // 
      // Cpf
      // 
      this.Cpf.Location = new System.Drawing.Point(283, 220);
      this.Cpf.Name = "Cpf";
      this.Cpf.Size = new System.Drawing.Size(139, 23);
      this.Cpf.TabIndex = 2;
      // 
      // DataNascimento
      // 
      this.DataNascimento.Location = new System.Drawing.Point(428, 220);
      this.DataNascimento.Name = "DataNascimento";
      this.DataNascimento.Size = new System.Drawing.Size(134, 23);
      this.DataNascimento.TabIndex = 3;
      // 
      // Sexo
      // 
      this.Sexo.FormattingEnabled = true;
      this.Sexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Não Identificado"});
      this.Sexo.Location = new System.Drawing.Point(568, 220);
      this.Sexo.Name = "Sexo";
      this.Sexo.Size = new System.Drawing.Size(150, 23);
      this.Sexo.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(283, 202);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(28, 15);
      this.label2.TabIndex = 5;
      this.label2.Text = "CPF";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(426, 202);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(114, 15);
      this.label3.TabIndex = 6;
      this.label3.Text = "Data de Nascimento";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(566, 202);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(32, 15);
      this.label4.TabIndex = 7;
      this.label4.Text = "Sexo";
      // 
      // BtnSalvar
      // 
      this.BtnSalvar.Location = new System.Drawing.Point(362, 301);
      this.BtnSalvar.Name = "BtnSalvar";
      this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
      this.BtnSalvar.TabIndex = 8;
      this.BtnSalvar.Text = "Cadastrar";
      this.BtnSalvar.UseVisualStyleBackColor = true;
      this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
      // 
      // frmPaciente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BtnSalvar);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.Sexo);
      this.Controls.Add(this.DataNascimento);
      this.Controls.Add(this.Cpf);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Nome);
      this.Name = "frmPaciente";
      this.Text = "Cadastro do Paciente";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private TextBox Nome;
        private Label label1;
        private TextBox Cpf;
        private TextBox DataNascimento;
        private ComboBox Sexo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnSalvar;
    }
}