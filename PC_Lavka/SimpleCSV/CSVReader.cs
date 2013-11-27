using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace SimpleCSV
{
  public class CSVReader
  {
    private string TextCSV;

    public CSVReader(string FilePath)
    {
      if (File.Exists(FilePath))
      {
        using (StreamReader file = new StreamReader(FilePath))
        {
          this.TextCSV = file.ReadToEnd();
        }
      }
      else
      {
        throw new FileNotFoundException("File not exists !!!", FilePath);
      }
    }

    public DataTable GetDataTable()
    {
      DataTable table = new DataTable();

      bool ifFirst = true;
      DataRow row = null;
      int i = 0;

      foreach (string str in TextCSV.Split('\n'))
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

      return table;
    }

  }
}
