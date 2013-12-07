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
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.ctmnBase = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.byVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.byCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripStatusLbPrice = new System.Windows.Forms.ToolStripStatusLabel();
      this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.productsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.allToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.byCategoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.byVendorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.userBoxCurrent = new Views.UserBox();
      this.menuBase.SuspendLayout();
      this.panelUser.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.ctmnBase.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuBase
      // 
      this.menuBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.adminToolStripMenuItem});
      this.menuBase.Location = new System.Drawing.Point(0, 0);
      this.menuBase.Name = "menuBase";
      this.menuBase.Size = new System.Drawing.Size(1110, 24);
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
      this.flpBase.BackColor = System.Drawing.SystemColors.Control;
      this.flpBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.flpBase.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flpBase.Location = new System.Drawing.Point(0, 0);
      this.flpBase.Name = "flpBase";
      this.flpBase.Size = new System.Drawing.Size(870, 305);
      this.flpBase.TabIndex = 2;
      this.flpBase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flpBase_MouseDown);
      // 
      // splitContainer1
      // 
      this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
      this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
      this.splitContainer1.Size = new System.Drawing.Size(870, 483);
      this.splitContainer1.SplitterDistance = 305;
      this.splitContainer1.TabIndex = 3;
      // 
      // flpShoppingCart
      // 
      this.flpShoppingCart.AutoScroll = true;
      this.flpShoppingCart.BackColor = System.Drawing.SystemColors.Control;
      this.flpShoppingCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.flpShoppingCart.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flpShoppingCart.Location = new System.Drawing.Point(0, 30);
      this.flpShoppingCart.Name = "flpShoppingCart";
      this.flpShoppingCart.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
      this.flpShoppingCart.Size = new System.Drawing.Size(870, 144);
      this.flpShoppingCart.TabIndex = 0;
      // 
      // statusStrip1
      // 
      this.statusStrip1.AutoSize = false;
      this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLbPrice});
      this.statusStrip1.Location = new System.Drawing.Point(0, 0);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(870, 30);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
      this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 25);
      this.toolStripStatusLabel1.Text = "Price:";
      // 
      // ctmnBase
      // 
      this.ctmnBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.clearToolStripMenuItem});
      this.ctmnBase.Name = "contextMenuStrip1";
      this.ctmnBase.Size = new System.Drawing.Size(122, 48);
      // 
      // productsToolStripMenuItem
      // 
      this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.toolStripMenuItem2,
            this.byVendorToolStripMenuItem,
            this.byCategoryToolStripMenuItem});
      this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
      this.productsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
      this.productsToolStripMenuItem.Text = "Products";
      // 
      // allToolStripMenuItem
      // 
      this.allToolStripMenuItem.Name = "allToolStripMenuItem";
      this.allToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
      this.allToolStripMenuItem.Text = "All";
      this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
      // 
      // clearToolStripMenuItem
      // 
      this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
      this.clearToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
      this.clearToolStripMenuItem.Text = "Clear";
      this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 6);
      // 
      // byVendorToolStripMenuItem
      // 
      this.byVendorToolStripMenuItem.Name = "byVendorToolStripMenuItem";
      this.byVendorToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
      this.byVendorToolStripMenuItem.Text = "By vendor";
      // 
      // byCategoryToolStripMenuItem
      // 
      this.byCategoryToolStripMenuItem.Name = "byCategoryToolStripMenuItem";
      this.byCategoryToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
      this.byCategoryToolStripMenuItem.Text = "By category";
      // 
      // toolStripStatusLbPrice
      // 
      this.toolStripStatusLbPrice.BackColor = System.Drawing.SystemColors.Control;
      this.toolStripStatusLbPrice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.toolStripStatusLbPrice.Name = "toolStripStatusLbPrice";
      this.toolStripStatusLbPrice.Size = new System.Drawing.Size(21, 25);
      this.toolStripStatusLbPrice.Text = "0";
      // 
      // showToolStripMenuItem
      // 
      this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem1,
            this.clearToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
      this.showToolStripMenuItem.Name = "showToolStripMenuItem";
      this.showToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.showToolStripMenuItem.Text = "Select";
      // 
      // productsToolStripMenuItem1
      // 
      this.productsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.byCategoryToolStripMenuItem1,
            this.byVendorToolStripMenuItem1});
      this.productsToolStripMenuItem1.Name = "productsToolStripMenuItem1";
      this.productsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
      this.productsToolStripMenuItem1.Text = "Products";
      // 
      // allToolStripMenuItem1
      // 
      this.allToolStripMenuItem1.Name = "allToolStripMenuItem1";
      this.allToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
      this.allToolStripMenuItem1.Text = "All";
      this.allToolStripMenuItem1.Click += new System.EventHandler(this.allToolStripMenuItem1_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 6);
      // 
      // byCategoryToolStripMenuItem1
      // 
      this.byCategoryToolStripMenuItem1.Name = "byCategoryToolStripMenuItem1";
      this.byCategoryToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
      this.byCategoryToolStripMenuItem1.Text = "By Category";
      // 
      // byVendorToolStripMenuItem1
      // 
      this.byVendorToolStripMenuItem1.Name = "byVendorToolStripMenuItem1";
      this.byVendorToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
      this.byVendorToolStripMenuItem1.Text = "By Vendor";
      // 
      // adminToolStripMenuItem
      // 
      this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
      this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
      this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
      this.adminToolStripMenuItem.Text = "Admin";
      // 
      // createToolStripMenuItem
      // 
      this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.vendorToolStripMenuItem,
            this.categoryToolStripMenuItem});
      this.createToolStripMenuItem.Name = "createToolStripMenuItem";
      this.createToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.createToolStripMenuItem.Text = "Create";
      // 
      // productToolStripMenuItem
      // 
      this.productToolStripMenuItem.Name = "productToolStripMenuItem";
      this.productToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.productToolStripMenuItem.Text = "Product";
      this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
      // 
      // vendorToolStripMenuItem
      // 
      this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
      this.vendorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.vendorToolStripMenuItem.Text = "Vendor";
      // 
      // categoryToolStripMenuItem
      // 
      this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
      this.categoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.categoryToolStripMenuItem.Text = "Category";
      // 
      // clearToolStripMenuItem1
      // 
      this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
      this.clearToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
      this.clearToolStripMenuItem1.Text = "Clear";
      this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
      this.ClientSize = new System.Drawing.Size(1110, 507);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.panelUser);
      this.Controls.Add(this.menuBase);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuBase;
      this.Name = "FormBase";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Load += new System.EventHandler(this.FormBase_Load);
      this.menuBase.ResumeLayout(false);
      this.menuBase.PerformLayout();
      this.panelUser.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
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
    private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem byVendorToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem byCategoryToolStripMenuItem;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbPrice;
    private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem1;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem byCategoryToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem byVendorToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
  }
}

