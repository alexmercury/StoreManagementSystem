using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;

namespace PC_Lavka
{
  public partial class UserLoginForm : Form
  {
    private FormBase parent;
    public UserLoginForm(FormBase parent)
    {
      InitializeComponent();
      this.parent = parent;
      this.btLogin.Enabled = false;
    }

    private void textBoxUID_TextChanged(object sender, EventArgs e)
    {
      ValidLogin();
    }

    private void textBoxPassword_TextChanged(object sender, EventArgs e)
    {
      ValidLogin();
    }

    private bool Login()
    {
      bool result = false;

      User user = new User();
      user = User.FindByUID(Convert.ToInt32(tbUID.Text));

      if (user != null && user.VerifyPassword(tbPassword.Text))
      {
        parent.CurrentUser = user;
        result = true;
      }

      return result;
    }

    private void buttonLogin_Click(object sender, EventArgs e)
    {
      if(Login())
      {
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      else
      {
        MessageBox.Show("Неверный пароль или логин !!!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      
    }

    private void ValidLogin()
    {
      if (tbPassword.Text.Length > 0 && tbUID.Text.Length > 0)
      {
        int UID = 0;
        if (Int32.TryParse(tbUID.Text, out UID))
        {
          btLogin.Enabled = true;
        }
        else
          btLogin.Enabled = false;
      }
      else
        btLogin.Enabled = false;
    }

  }
}