using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;
using System.Windows.Forms;

namespace SqlManaging
{
  public class SqlManager : IDisposable
  {
    private DbConnection connection = null;
    private DbCommand command = null;
    private DbDataReader reader = null;
    private String connectionString = null;

    public SqlManager(string connectionString)
    {
      this.connectionString = connectionString;
    }

    public bool TryToConnect()
    {
      bool result = false;
      try
      {
        connection = new SqlConnection(connectionString);
        connection.Open();
        if (connection.State == ConnectionState.Open)
        {
          result = true;
          connection.Close();
          connection.Dispose();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

      return result;
    }

    public void Dispose()
    {
      connection.Dispose();
      command.Dispose();
      reader.Dispose();
      connectionString = null;
    }
  }
}
