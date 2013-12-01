namespace Views
{
  partial class UserBox
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

    #region Код, автоматически созданный конструктором компонентов

    /// <summary> 
    /// Обязательный метод для поддержки конструктора - не изменяйте 
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelUID = new System.Windows.Forms.Label();
      this.labelSurname = new System.Windows.Forms.Label();
      this.labelName = new System.Windows.Forms.Label();
      this.labelPatronymic = new System.Windows.Forms.Label();
      this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
      this.SuspendLayout();
      // 
      // labelUID
      // 
      this.labelUID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelUID.Location = new System.Drawing.Point(0, 250);
      this.labelUID.Name = "labelUID";
      this.labelUID.Size = new System.Drawing.Size(240, 30);
      this.labelUID.TabIndex = 0;
      this.labelUID.Text = "UID";
      this.labelUID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // labelSurname
      // 
      this.labelSurname.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSurname.Location = new System.Drawing.Point(0, 280);
      this.labelSurname.Name = "labelSurname";
      this.labelSurname.Size = new System.Drawing.Size(240, 30);
      this.labelSurname.TabIndex = 2;
      this.labelSurname.Text = "surname";
      this.labelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // labelName
      // 
      this.labelName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelName.Location = new System.Drawing.Point(0, 310);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(240, 30);
      this.labelName.TabIndex = 3;
      this.labelName.Text = "name";
      this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // labelPatronymic
      // 
      this.labelPatronymic.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelPatronymic.Location = new System.Drawing.Point(0, 340);
      this.labelPatronymic.Name = "labelPatronymic";
      this.labelPatronymic.Size = new System.Drawing.Size(240, 30);
      this.labelPatronymic.TabIndex = 4;
      this.labelPatronymic.Text = "patronymic";
      this.labelPatronymic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pictureBoxPhoto
      // 
      this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBoxPhoto.ErrorImage = global::PC_Lavka.Properties.Resources.no_image;
      this.pictureBoxPhoto.Location = new System.Drawing.Point(45, 10);
      this.pictureBoxPhoto.Name = "pictureBoxPhoto";
      this.pictureBoxPhoto.Size = new System.Drawing.Size(150, 225);
      this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBoxPhoto.TabIndex = 1;
      this.pictureBoxPhoto.TabStop = false;
      // 
      // UserBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.Controls.Add(this.labelPatronymic);
      this.Controls.Add(this.labelName);
      this.Controls.Add(this.labelSurname);
      this.Controls.Add(this.pictureBoxPhoto);
      this.Controls.Add(this.labelUID);
      this.Name = "UserBox";
      this.Size = new System.Drawing.Size(240, 370);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label labelUID;
    private System.Windows.Forms.PictureBox pictureBoxPhoto;
    private System.Windows.Forms.Label labelSurname;
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.Label labelPatronymic;
  }
}
