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
      this.buttonNext = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.richTextBoxConnStr = new System.Windows.Forms.RichTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // buttonNext
      // 
      this.buttonNext.Location = new System.Drawing.Point(320, 227);
      this.buttonNext.Name = "buttonNext";
      this.buttonNext.Size = new System.Drawing.Size(75, 23);
      this.buttonNext.TabIndex = 0;
      this.buttonNext.Text = "Next >>";
      this.buttonNext.UseVisualStyleBackColor = true;
      this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(12, 227);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // richTextBoxConnStr
      // 
      this.richTextBoxConnStr.BackColor = System.Drawing.SystemColors.Control;
      this.richTextBoxConnStr.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.richTextBoxConnStr.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.richTextBoxConnStr.ForeColor = System.Drawing.Color.Gray;
      this.richTextBoxConnStr.Location = new System.Drawing.Point(12, 34);
      this.richTextBoxConnStr.Name = "richTextBoxConnStr";
      this.richTextBoxConnStr.Size = new System.Drawing.Size(383, 187);
      this.richTextBoxConnStr.TabIndex = 2;
      this.richTextBoxConnStr.Text = "";
      this.richTextBoxConnStr.TextChanged += new System.EventHandler(this.richTextBoxConnStr_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(165, 22);
      this.label1.TabIndex = 3;
      this.label1.Text = "Connection String:";
      // 
      // FormInstall
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(407, 257);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.richTextBoxConnStr);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.buttonNext);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "FormInstall";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Installation";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonNext;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.RichTextBox richTextBoxConnStr;
    private System.Windows.Forms.Label label1;
  }
}