namespace FormFor
{
  partial class ProductForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
      this.label1 = new System.Windows.Forms.Label();
      this.tbName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tbPrice = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.btnImg = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.combVendor = new System.Windows.Forms.ComboBox();
      this.combCategory = new System.Windows.Forms.ComboBox();
      this.btnCreate = new System.Windows.Forms.Button();
      this.rtbSpecification = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 22);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name";
      // 
      // tbName
      // 
      this.tbName.Location = new System.Drawing.Point(137, 13);
      this.tbName.Name = "tbName";
      this.tbName.Size = new System.Drawing.Size(100, 20);
      this.tbName.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(12, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(119, 22);
      this.label2.TabIndex = 2;
      this.label2.Text = "Specification";
      // 
      // tbPrice
      // 
      this.tbPrice.Location = new System.Drawing.Point(352, 43);
      this.tbPrice.Name = "tbPrice";
      this.tbPrice.Size = new System.Drawing.Size(121, 20);
      this.tbPrice.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(260, 39);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(54, 22);
      this.label3.TabIndex = 4;
      this.label3.Text = "Price";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(260, 9);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(64, 22);
      this.label4.TabIndex = 6;
      this.label4.Text = "Image";
      // 
      // btnImg
      // 
      this.btnImg.Location = new System.Drawing.Point(352, 10);
      this.btnImg.Name = "btnImg";
      this.btnImg.Size = new System.Drawing.Size(121, 23);
      this.btnImg.TabIndex = 7;
      this.btnImg.Text = "...";
      this.btnImg.UseVisualStyleBackColor = true;
      this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(260, 65);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(71, 22);
      this.label5.TabIndex = 8;
      this.label5.Text = "Vendor";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(259, 95);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(87, 22);
      this.label6.TabIndex = 9;
      this.label6.Text = "Category";
      // 
      // combVendor
      // 
      this.combVendor.FormattingEnabled = true;
      this.combVendor.Location = new System.Drawing.Point(352, 69);
      this.combVendor.Name = "combVendor";
      this.combVendor.Size = new System.Drawing.Size(121, 21);
      this.combVendor.TabIndex = 10;
      // 
      // combCategory
      // 
      this.combCategory.FormattingEnabled = true;
      this.combCategory.Location = new System.Drawing.Point(352, 96);
      this.combCategory.Name = "combCategory";
      this.combCategory.Size = new System.Drawing.Size(121, 21);
      this.combCategory.TabIndex = 11;
      // 
      // btnCreate
      // 
      this.btnCreate.Location = new System.Drawing.Point(398, 184);
      this.btnCreate.Name = "btnCreate";
      this.btnCreate.Size = new System.Drawing.Size(75, 23);
      this.btnCreate.TabIndex = 12;
      this.btnCreate.Text = "Create";
      this.btnCreate.UseVisualStyleBackColor = true;
      this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
      // 
      // rtbSpecification
      // 
      this.rtbSpecification.Location = new System.Drawing.Point(16, 64);
      this.rtbSpecification.Name = "rtbSpecification";
      this.rtbSpecification.Size = new System.Drawing.Size(221, 143);
      this.rtbSpecification.TabIndex = 13;
      this.rtbSpecification.Text = "";
      // 
      // ProductForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 222);
      this.Controls.Add(this.rtbSpecification);
      this.Controls.Add(this.btnCreate);
      this.Controls.Add(this.combCategory);
      this.Controls.Add(this.combVendor);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.btnImg);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.tbPrice);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbName);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "ProductForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Product creation";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.ProductForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbPrice;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnImg;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox combVendor;
    private System.Windows.Forms.ComboBox combCategory;
    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.RichTextBox rtbSpecification;
  }
}