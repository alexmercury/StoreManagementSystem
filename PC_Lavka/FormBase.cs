using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCSV;
using Models;
using System.Configuration;
using SqlManaging;
using Install;

namespace PC_Lavka
{
  public partial class FormBase : Form
  {
    public User CurrentUser;

    public FormBase()
    {
      InitializeComponent();
      CurrentUser = new User();
    }

    private void FormBase_Load(object sender, EventArgs e)
    {
      if (ConfigurationManager.AppSettings["Installed"] == "false")
      {
        FormInstall form = new FormInstall();
        if (form.ShowDialog() == DialogResult.OK)
        {
          Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
          config.AppSettings.Settings.Remove("Installed");
          config.AppSettings.Settings.Add("Installed", "true");
          config.Save(ConfigurationSaveMode.Minimal);
        }
        else
          this.Close();
      }
      else
      {
        SqlManager.ConnectToServer(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString);
        UserLoginForm login = new UserLoginForm(this);
        if (login.ShowDialog() == DialogResult.OK)
        {
          userBoxCurrent.SetCurrentUser(CurrentUser);
        }
        else
        {
          this.Close();
        }
      }   
    }

  }
}