using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;

namespace Views
{
  public partial class UserBox : UserControl
  {
    private User user = null;

    public UserBox()
    {
      InitializeComponent();
    }

    public void SetCurrentUser(User user)
    {
      this.user = user;
      labelUID.Text = user.UID.ToString();
      if (user.is_admin)
        labelUID.Text += "* (admin)";
      labelSurname.Text = user.Surname;
      labelName.Text = user.Name;
      labelPatronymic.Text = user.Patronymic;
      pictureBoxPhoto.Image = user.Photo;
    }

  }
}