namespace Install
{
  partial class FormInstall
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
      this.btNext = new System.Windows.Forms.Button();
      this.rtbContent = new System.Windows.Forms.RichTextBox();
      this.lbHeader = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btNext
      // 
      this.btNext.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btNext.Location = new System.Drawing.Point(320, 215);
      this.btNext.Name = "btNext";
      this.btNext.Size = new System.Drawing.Size(75, 30);
      this.btNext.TabIndex = 0;
      this.btNext.Text = "Далее >>";
      this.btNext.UseVisualStyleBackColor = true;
      this.btNext.Click += new System.EventHandler(this.buttonNext_Click);
      // 
      // rtbContent
      // 
      this.rtbContent.BackColor = System.Drawing.SystemColors.Control;
      this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.rtbContent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.rtbContent.ForeColor = System.Drawing.Color.Gray;
      this.rtbContent.Location = new System.Drawing.Point(12, 34);
      this.rtbContent.Name = "rtbContent";
      this.rtbContent.Size = new System.Drawing.Size(383, 175);
      this.rtbContent.TabIndex = 2;
      this.rtbContent.Text = "";
      this.rtbContent.TextChanged += new System.EventHandler(this.richTextBoxConnStr_TextChanged);
      // 
      // lbHeader
      // 
      this.lbHeader.AutoSize = true;
      this.lbHeader.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbHeader.ForeColor = System.Drawing.Color.Black;
      this.lbHeader.Location = new System.Drawing.Point(12, 9);
      this.lbHeader.Name = "lbHeader";
      this.lbHeader.Size = new System.Drawing.Size(196, 22);
      this.lbHeader.TabIndex = 3;
      this.lbHeader.Text = "Строка подключения:";
      // 
      // FormInstall
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(407, 257);
      this.Controls.Add(this.lbHeader);
      this.Controls.Add(this.rtbContent);
      this.Controls.Add(this.btNext);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "FormInstall";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Установка";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btNext;
    private System.Windows.Forms.RichTextBox rtbContent;
    private System.Windows.Forms.Label lbHeader;
  }
}