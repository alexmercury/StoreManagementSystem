using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using SqlManaging;

namespace Install
{
  public partial class FormInstall : Form
  {
    String conn_str = null;
    SqlManager manager = null;

    public FormInstall()
    {
      InitializeComponent();
      conn_str = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
      richTextBoxConnStr.Text = conn_str;
    }

    private void ConnectionSqlServer()
    {
      manager = new SqlManager(conn_str);

      if (manager.TryToConnect())
      {
        MessageBox.Show("Connection success !!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        MessageBox.Show("Connection failed !!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonNext_Click(object sender, EventArgs e)
    {
      ConnectionSqlServer();
    }

    private void richTextBoxConnStr_TextChanged(object sender, EventArgs e)
    {
      conn_str = richTextBoxConnStr.Text;
    }

  }
}
