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
      this.lbName = new System.Windows.Forms.Label();
      this.pbPhoto = new System.Windows.Forms.PictureBox();
      this.rtbContent = new System.Windows.Forms.RichTextBox();
      this.btnDelete = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.lbPrice = new System.Windows.Forms.Label();
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
      // rtbContent
      // 
      this.rtbContent.BackColor = System.Drawing.SystemColors.ButtonShadow;
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
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(178, 185);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(46, 44);
      this.btnDelete.TabIndex = 3;
      this.btnDelete.Text = "del";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(230, 185);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(46, 44);
      this.button1.TabIndex = 4;
      this.button1.Text = "add";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
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
      // ProductBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.lbPrice);
      this.Controls.Add(this.button1);
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
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label lbPrice;
  }
}
