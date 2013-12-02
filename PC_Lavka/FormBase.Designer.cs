namespace PC_Lavka
{
  partial class FormBase
  {
    /// <summary>
    /// Требуется переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Обязательный метод для поддержки конструктора - не изменяйте
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuBase = new System.Windows.Forms.MenuStrip();
      this.panelUser = new System.Windows.Forms.Panel();
      this.userBoxCurrent = new Views.UserBox();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.panelUser.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuBase
      // 
      this.menuBase.Location = new System.Drawing.Point(0, 0);
      this.menuBase.Name = "menuBase";
      this.menuBase.Size = new System.Drawing.Size(1006, 24);
      this.menuBase.TabIndex = 0;
      this.menuBase.Text = "menuStrip1";
      // 
      // panelUser
      // 
      this.panelUser.BackColor = System.Drawing.SystemColors.Control;
      this.panelUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelUser.Controls.Add(this.userBoxCurrent);
      this.panelUser.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelUser.Location = new System.Drawing.Point(0, 24);
      this.panelUser.Name = "panelUser";
      this.panelUser.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
      this.panelUser.Size = new System.Drawing.Size(240, 483);
      this.panelUser.TabIndex = 1;
      // 
      // userBoxCurrent
      // 
      this.userBoxCurrent.BackColor = System.Drawing.SystemColors.Control;
      this.userBoxCurrent.Location = new System.Drawing.Point(-1, 13);
      this.userBoxCurrent.Name = "userBoxCurrent";
      this.userBoxCurrent.Size = new System.Drawing.Size(240, 370);
      this.userBoxCurrent.TabIndex = 0;
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(240, 24);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(766, 483);
      this.flowLayoutPanel1.TabIndex = 2;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(3, 3);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(598, 255);
      this.dataGridView1.TabIndex = 0;
      // 
      // FormBase
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1006, 507);
      this.Controls.Add(this.flowLayoutPanel1);
      this.Controls.Add(this.panelUser);
      this.Controls.Add(this.menuBase);
      this.MainMenuStrip = this.menuBase;
      this.Name = "FormBase";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Load += new System.EventHandler(this.FormBase_Load);
      this.panelUser.ResumeLayout(false);
      this.flowLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuBase;
    private System.Windows.Forms.Panel panelUser;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private Views.UserBox userBoxCurrent;
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}

