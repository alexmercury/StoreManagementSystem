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
    private String conn_str = null;
    private SqlManager manager = null;
    private int step;

    public FormInstall()
    {
      InitializeComponent();
      conn_str = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
      step = 0;
      richTextBoxConnStr.Text = conn_str;
    }

    private void buttonNext_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      switch (step)
      {
        case 0:
          ConnectionSqlServer();
          break;
        case 1:
          CreateTables();
          break;
      }
      Cursor = Cursors.Default;
      richTextBoxConnStr.Cursor = Cursors.Default;

    }

    private void richTextBoxConnStr_TextChanged(object sender, EventArgs e)
    {
      conn_str = richTextBoxConnStr.Text;
    }

    private void ConnectionSqlServer()
    {
      manager = new SqlManager(conn_str);
      if (manager.TryToConnect())
      {
        //MessageBox.Show("Connection success !!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        labelBase.Text = "Connection success !!!";
        labelBase.ForeColor = Color.Green;
        richTextBoxConnStr.ReadOnly = true;
        richTextBoxConnStr.Text = "Click 'Next >>' to start database tables creation ...";
        buttonNext.ForeColor = Color.Green;
        step++;
      }
      else
      {
        //MessageBox.Show("Connection failed !!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        labelBase.Text = "Connection failed !!!";
        labelBase.ForeColor = Color.Red;
      }
    }

    private void CreateTables()
    {
      richTextBoxConnStr.Cursor = Cursors.WaitCursor;
      using (StreamReader file = new StreamReader(@"TestData\install\users.sql"))
      {
        string query = file.ReadToEnd();
        manager.ExecCommand(query);
        richTextBoxConnStr.Text = "Tabe [users] created successful !!!\n";
      }
      using (StreamReader file = new StreamReader(@"TestData\install\vendors.sql"))
      {
        string query = file.ReadToEnd();
        manager.ExecCommand(query);
        richTextBoxConnStr.Text += "Tabe [vendors] created successful !!!\n";
      }
      using (StreamReader file = new StreamReader(@"TestData\install\categories.sql"))
      {
        string query = file.ReadToEnd();
        manager.ExecCommand(query);
        richTextBoxConnStr.Text += "Tabe [categories] created successful !!!\n";
      }
      using (StreamReader file = new StreamReader(@"TestData\install\products.sql"))
      {
        string query = file.ReadToEnd();
        manager.ExecCommand(query);
        richTextBoxConnStr.Text += "Tabe [products] created successful !!!\n";
      }
      richTextBoxConnStr.Text += "Click 'Next >>' to start add data...";
      step++;
    }
  }
}