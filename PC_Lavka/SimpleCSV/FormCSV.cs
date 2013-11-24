using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SimpleCSV
{
  public partial class FormCSV : Form
  {
    public FormCSV()
    {
      InitializeComponent();
    }

    private void menuItemOpen_Click(object sender, EventArgs e)
    {
      OpenFile();
    }

    private void OpenFile()
    {
      OpenFileDialog OpenFD = new OpenFileDialog();
      OpenFD.InitialDirectory = String.Format("{0}\\Data", Directory.GetCurrentDirectory());
      OpenFD.Filter = "CSV files (.csv)|*.csv";

      DataTable table = new DataTable();

      if (OpenFD.ShowDialog() == DialogResult.OK)
      {
        string FileCSV = OpenFD.FileName;

        using (StreamReader file = new StreamReader(FileCSV))
        {
          FileCSV = file.ReadToEnd();
          bool ifFirst = true;
          DataRow row = null;
          int i = 0;

          foreach (string str in FileCSV.Split('\n'))
          {
            if (!ifFirst)
              row = table.NewRow();

            foreach (string col in str.TrimEnd('\r').Split(';'))
            {
              if (ifFirst)
                table.Columns.Add(col);
              else
              {
                row[i++] = col;
              }
            }
            i = 0;
            if (!ifFirst)
              table.Rows.Add(row);

            ifFirst = false;
          }
        }

        dataGridView1.DataSource = table;

      }
    }

    private void CSVparser()
    {

    }
  }
}
