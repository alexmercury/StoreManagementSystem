namespace SimpleCSV
{
  partial class FormCSV
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCSV));
      this.menuBase = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.menuBase.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuBase
      // 
      this.menuBase.BackColor = System.Drawing.SystemColors.Menu;
      this.menuBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuBase.Location = new System.Drawing.Point(0, 0);
      this.menuBase.Name = "menuBase";
      this.menuBase.Size = new System.Drawing.Size(744, 24);
      this.menuBase.TabIndex = 0;
      this.menuBase.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // menuItemOpen
      // 
      this.menuItemOpen.Name = "menuItemOpen";
      this.menuItemOpen.Size = new System.Drawing.Size(136, 22);
      this.menuItemOpen.Text = "Open (*csv)";
      this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 24);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(744, 478);
      this.dataGridView1.TabIndex = 1;
      // 
      // FormCSV
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(744, 502);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.menuBase);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuBase;
      this.Name = "FormCSV";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FormCSV";
      this.menuBase.ResumeLayout(false);
      this.menuBase.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuBase;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}