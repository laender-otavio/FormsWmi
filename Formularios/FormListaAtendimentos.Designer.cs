namespace FormsWmi
{
  partial class FormListaAtendimentos
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
      this.components = new System.ComponentModel.Container();
      this.atendimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DataGridView = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.atendimentoBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // atendimentoBindingSource
      // 
      this.atendimentoBindingSource.DataSource = typeof(FormsWmi.Atendimento);
      // 
      // DataGridView
      // 
      this.DataGridView.AllowUserToAddRows = false;
      this.DataGridView.AllowUserToDeleteRows = false;
      this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataGridView.Location = new System.Drawing.Point(43, 40);
      this.DataGridView.Name = "DataGridView";
      this.DataGridView.ReadOnly = true;
      this.DataGridView.RowTemplate.Height = 25;
      this.DataGridView.Size = new System.Drawing.Size(697, 353);
      this.DataGridView.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(43, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(125, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Lista de Atendimentos";
      // 
      // FormListaAtendimentos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.DataGridView);
      this.Name = "FormListaAtendimentos";
      this.Text = "Lista de Atendimentos";
      this.Load += new System.EventHandler(this.FormListaAtendimentos_Load);
      ((System.ComponentModel.ISupportInitialize)(this.atendimentoBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private BindingSource atendimentoBindingSource;
        private DataGridView DataGridView;
        private Label label1;
    }
}