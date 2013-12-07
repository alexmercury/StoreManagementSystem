namespace Views
{
  partial class ProductBox
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductBox));
      this.lbName = new System.Windows.Forms.Label();
      this.rtbContent = new System.Windows.Forms.RichTextBox();
      this.lbPrice = new System.Windows.Forms.Label();
      this.btnRemove = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btAddShoppingCart = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.pbPhoto = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
      this.SuspendLayout();
      // 
      // lbName
      // 
      this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
      this.lbName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbName.Location = new System.Drawing.Point(0, 0);
      this.lbName.Name = "lbName";
      this.lbName.Size = new System.Drawing.Size(377, 18);
      this.lbName.TabIndex = 0;
      this.lbName.Text = "label1";
      this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // rtbContent
      // 
      this.rtbContent.BackColor = System.Drawing.SystemColors.Control;
      this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.rtbContent.Cursor = System.Windows.Forms.Cursors.Default;
      this.rtbContent.Location = new System.Drawing.Point(179, 22);
      this.rtbContent.Name = "rtbContent";
      this.rtbContent.ReadOnly = true;
      this.rtbContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
      this.rtbContent.Size = new System.Drawing.Size(195, 107);
      this.rtbContent.TabIndex = 2;
      this.rtbContent.Text = "";
      // 
      // lbPrice
      // 
      this.lbPrice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbPrice.Location = new System.Drawing.Point(178, 132);
      this.lbPrice.Name = "lbPrice";
      this.lbPrice.Size = new System.Drawing.Size(196, 23);
      this.lbPrice.TabIndex = 5;
      this.lbPrice.Text = "0";
      this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnRemove
      // 
      this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnRemove.Image = global::PC_Lavka.Properties.Resources.deletered;
      this.btnRemove.Location = new System.Drawing.Point(327, 185);
      this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(46, 44);
      this.btnRemove.TabIndex = 7;
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // btnUpdate
      // 
      this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
      this.btnUpdate.Location = new System.Drawing.Point(277, 185);
      this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(46, 44);
      this.btnUpdate.TabIndex = 6;
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // btAddShoppingCart
      // 
      this.btAddShoppingCart.Image = global::PC_Lavka.Properties.Resources.cart_add;
      this.btAddShoppingCart.Location = new System.Drawing.Point(227, 185);
      this.btAddShoppingCart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.btAddShoppingCart.Name = "btAddShoppingCart";
      this.btAddShoppingCart.Size = new System.Drawing.Size(46, 44);
      this.btAddShoppingCart.TabIndex = 4;
      this.btAddShoppingCart.UseVisualStyleBackColor = true;
      this.btAddShoppingCart.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Image = global::PC_Lavka.Properties.Resources.cart_remove;
      this.btnDelete.Location = new System.Drawing.Point(177, 185);
      this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(46, 44);
      this.btnDelete.TabIndex = 3;
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // pbPhoto
      // 
      this.pbPhoto.ErrorImage = global::PC_Lavka.Properties.Resources.no_image;
      this.pbPhoto.Location = new System.Drawing.Point(3, 21);
      this.pbPhoto.Name = "pbPhoto";
      this.pbPhoto.Size = new System.Drawing.Size(169, 208);
      this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbPhoto.TabIndex = 1;
      this.pbPhoto.TabStop = false;
      // 
      // ProductBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.btnRemove);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.lbPrice);
      this.Controls.Add(this.btAddShoppingCart);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.rtbContent);
      this.Controls.Add(this.pbPhoto);
      this.Controls.Add(this.lbName);
      this.Name = "ProductBox";
      this.Size = new System.Drawing.Size(377, 232);
      this.Load += new System.EventHandler(this.ProductBox_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lbName;
    private System.Windows.Forms.PictureBox pbPhoto;
    private System.Windows.Forms.RichTextBox rtbContent;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btAddShoppingCart;
    private System.Windows.Forms.Label lbPrice;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnRemove;
  }
}
