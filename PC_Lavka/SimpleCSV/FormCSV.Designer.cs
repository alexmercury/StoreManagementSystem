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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.statusStripBase = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabelPath = new System.Windows.Forms.ToolStripStatusLabel();
      this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.menuBase.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.statusStripBase.SuspendLayout();
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
      // dataGridView1
      // 
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 24);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(744, 449);
      this.dataGridView1.TabIndex = 1;
      // 
      // statusStripBase
      // 
      this.statusStripBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelPath});
      this.statusStripBase.Location = new System.Drawing.Point(0, 473);
      this.statusStripBase.Name = "statusStripBase";
      this.statusStripBase.Size = new System.Drawing.Size(744, 29);
      this.statusStripBase.TabIndex = 2;
      this.statusStripBase.Text = "statusStrip1";
      // 
      // toolStripStatusLabelPath
      // 
      this.toolStripStatusLabelPath.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.toolStripStatusLabelPath.Image = global::PC_Lavka.Properties.Resources.gtk_directory;
      this.toolStripStatusLabelPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.toolStripStatusLabelPath.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.toolStripStatusLabelPath.Name = "toolStripStatusLabelPath";
      this.toolStripStatusLabelPath.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
      this.toolStripStatusLabelPath.Size = new System.Drawing.Size(44, 24);
      this.toolStripStatusLabelPath.Spring = true;
      this.toolStripStatusLabelPath.Text = "...";
      this.toolStripStatusLabelPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // menuItemOpen
      // 
      this.menuItemOpen.Image = global::PC_Lavka.Properties.Resources.open_win7_hot;
      this.menuItemOpen.Name = "menuItemOpen";
      this.menuItemOpen.Size = new System.Drawing.Size(152, 22);
      this.menuItemOpen.Text = "Open (*csv)";
      this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
      // 
      // FormCSV
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(744, 502);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.statusStripBase);
      this.Controls.Add(this.menuBase);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuBase;
      this.Name = "FormCSV";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Simple CSV";
      this.menuBase.ResumeLayout(false);
      this.menuBase.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.statusStripBase.ResumeLayout(false);
      this.statusStripBase.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuBase;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.StatusStrip statusStripBase;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPath;
  }
}