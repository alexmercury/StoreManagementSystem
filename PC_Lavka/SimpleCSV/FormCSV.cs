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
      OpenFD.InitialDirectory = String.Format("{0}\\TestData", Directory.GetCurrentDirectory());
      OpenFD.Filter = "CSV files (.csv)|*.csv";

      if (OpenFD.ShowDialog() == DialogResult.OK)
      {
        toolStripStatusLabelPath.Text = OpenFD.FileName;
        CSVReader reader = new CSVReader(OpenFD.FileName);
        dataGridView1.DataSource = reader.GetDataTable();
      }
    }

  }
}
