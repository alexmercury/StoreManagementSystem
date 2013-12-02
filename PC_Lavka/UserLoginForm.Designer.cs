namespace PC_Lavka
{
  partial class UserLoginForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginForm));
      this.lbUID = new System.Windows.Forms.Label();
      this.tbUID = new System.Windows.Forms.TextBox();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.lbPassword = new System.Windows.Forms.Label();
      this.btLogin = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lbUID
      // 
      this.lbUID.AutoSize = true;
      this.lbUID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbUID.Location = new System.Drawing.Point(12, 14);
      this.lbUID.Name = "lbUID";
      this.lbUID.Size = new System.Drawing.Size(45, 24);
      this.lbUID.TabIndex = 0;
      this.lbUID.Text = "UID";
      // 
      // tbUID
      // 
      this.tbUID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.tbUID.Location = new System.Drawing.Point(121, 12);
      this.tbUID.MaxLength = 10;
      this.tbUID.Name = "tbUID";
      this.tbUID.Size = new System.Drawing.Size(157, 29);
      this.tbUID.TabIndex = 1;
      this.tbUID.TextChanged += new System.EventHandler(this.textBoxUID_TextChanged);
      // 
      // tbPassword
      // 
      this.tbPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.tbPassword.Location = new System.Drawing.Point(121, 47);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.PasswordChar = '■';
      this.tbPassword.Size = new System.Drawing.Size(157, 29);
      this.tbPassword.TabIndex = 3;
      this.tbPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
      // 
      // lbPassword
      // 
      this.lbPassword.AutoSize = true;
      this.lbPassword.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbPassword.Location = new System.Drawing.Point(12, 49);
      this.lbPassword.Name = "lbPassword";
      this.lbPassword.Size = new System.Drawing.Size(103, 24);
      this.lbPassword.TabIndex = 2;
      this.lbPassword.Text = "Password";
      // 
      // btLogin
      // 
      this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btLogin.Image = global::PC_Lavka.Properties.Resources.log_in;
      this.btLogin.Location = new System.Drawing.Point(284, 12);
      this.btLogin.Name = "btLogin";
      this.btLogin.Size = new System.Drawing.Size(75, 66);
      this.btLogin.TabIndex = 4;
      this.btLogin.UseVisualStyleBackColor = true;
      this.btLogin.Click += new System.EventHandler(this.buttonLogin_Click);
      // 
      // UserLoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(369, 90);
      this.Controls.Add(this.btLogin);
      this.Controls.Add(this.tbPassword);
      this.Controls.Add(this.lbPassword);
      this.Controls.Add(this.tbUID);
      this.Controls.Add(this.lbUID);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "UserLoginForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbUID;
    private System.Windows.Forms.TextBox tbUID;
    private System.Windows.Forms.TextBox tbPassword;
    private System.Windows.Forms.Label lbPassword;
    private System.Windows.Forms.Button btLogin;
  }
}