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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
      this.menuBase = new System.Windows.Forms.MenuStrip();
      this.panelUser = new System.Windows.Forms.Panel();
      this.flpBase = new System.Windows.Forms.FlowLayoutPanel();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.flpShoppingCart = new System.Windows.Forms.FlowLayoutPanel();
      this.ctmnBase = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.vendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.allToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.allToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.userBoxCurrent = new Views.UserBox();
      this.panelUser.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.ctmnBase.SuspendLayout();
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
      // flpBase
      // 
      this.flpBase.AutoScroll = true;
      this.flpBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.flpBase.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flpBase.Location = new System.Drawing.Point(0, 0);
      this.flpBase.Name = "flpBase";
      this.flpBase.Size = new System.Drawing.Size(766, 360);
      this.flpBase.TabIndex = 2;
      this.flpBase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flpBase_MouseDown);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(240, 24);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.flpBase);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.flpShoppingCart);
      this.splitContainer1.Size = new System.Drawing.Size(766, 483);
      this.splitContainer1.SplitterDistance = 360;
      this.splitContainer1.TabIndex = 3;
      // 
      // flpShoppingCart
      // 
      this.flpShoppingCart.AutoScroll = true;
      this.flpShoppingCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.flpShoppingCart.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flpShoppingCart.Location = new System.Drawing.Point(0, 0);
      this.flpShoppingCart.Name = "flpShoppingCart";
      this.flpShoppingCart.Size = new System.Drawing.Size(766, 119);
      this.flpShoppingCart.TabIndex = 0;
      // 
      // ctmnBase
      // 
      this.ctmnBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.vendorsToolStripMenuItem,
            this.categoryToolStripMenuItem});
      this.ctmnBase.Name = "contextMenuStrip1";
      this.ctmnBase.Size = new System.Drawing.Size(123, 70);
      // 
      // productsToolStripMenuItem
      // 
      this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem});
      this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
      this.productsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.productsToolStripMenuItem.Text = "Products";
      // 
      // allToolStripMenuItem
      // 
      this.allToolStripMenuItem.Name = "allToolStripMenuItem";
      this.allToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.allToolStripMenuItem.Text = "All";
      this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
      // 
      // vendorsToolStripMenuItem
      // 
      this.vendorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem1});
      this.vendorsToolStripMenuItem.Name = "vendorsToolStripMenuItem";
      this.vendorsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.vendorsToolStripMenuItem.Text = "Vendors";
      // 
      // allToolStripMenuItem1
      // 
      this.allToolStripMenuItem1.Name = "allToolStripMenuItem1";
      this.allToolStripMenuItem1.Size = new System.Drawing.Size(88, 22);
      this.allToolStripMenuItem1.Text = "All";
      // 
      // categoryToolStripMenuItem
      // 
      this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem2});
      this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
      this.categoryToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.categoryToolStripMenuItem.Text = "Category";
      // 
      // allToolStripMenuItem2
      // 
      this.allToolStripMenuItem2.Name = "allToolStripMenuItem2";
      this.allToolStripMenuItem2.Size = new System.Drawing.Size(88, 22);
      this.allToolStripMenuItem2.Text = "All";
      // 
      // userBoxCurrent
      // 
      this.userBoxCurrent.BackColor = System.Drawing.SystemColors.Control;
      this.userBoxCurrent.Location = new System.Drawing.Point(-1, 13);
      this.userBoxCurrent.Name = "userBoxCurrent";
      this.userBoxCurrent.Size = new System.Drawing.Size(240, 370);
      this.userBoxCurrent.TabIndex = 0;
      // 
      // FormBase
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1006, 507);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.panelUser);
      this.Controls.Add(this.menuBase);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuBase;
      this.Name = "FormBase";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Load += new System.EventHandler(this.FormBase_Load);
      this.panelUser.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ctmnBase.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuBase;
    private System.Windows.Forms.Panel panelUser;
    private System.Windows.Forms.FlowLayoutPanel flpBase;
    private Views.UserBox userBoxCurrent;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.FlowLayoutPanel flpShoppingCart;
    private System.Windows.Forms.ContextMenuStrip ctmnBase;
    private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem vendorsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem2;
  }
}

