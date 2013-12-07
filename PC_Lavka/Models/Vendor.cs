using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Models
{
  public class Vendor
  {
    public int ID;
    public string Name;

    public Vendor()
    {
      this.ID = 0;
      this.Name = "";
    }

    public Vendor(DataRow row)
    {
      this.ID = Convert.ToInt32(row["id"]);
      this.Name = row["name"].ToString();
    }

    public Vendor(string Name)
    {
      this.Name = Name;
    }

    public void Save()
    {
      try
      {
        SqlConnection conn = GetSqlConnection();
        conn.Open();
        SqlCommand comm = new SqlCommand("INSERT INTO [vendors] ([name]) VALUES (@p1);", conn);
        comm.Parameters.Add("@p1", SqlDbType.NVarChar, 50).Value = this.Name;

        comm.ExecuteNonQuery();
        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public static Vendor Create(string Name)
    {
      Vendor vendor = new Vendor(Name);
      vendor.Save();
      return vendor;
    }

    public static List<Vendor> All()
    {
      List<Vendor> vendors = new List<Vendor>();
      Vendor vendor = new Vendor();
      try
      {
        SqlConnection conn = vendor.GetSqlConnection();
        conn.Open();
        SqlCommand comm = new SqlCommand("SELECT * FROM [vendors];", conn);
        foreach (DataRow row in vendor.ReaderToTable(comm.ExecuteReader()).Rows)
        {
          vendors.Add(new Vendor(row));
        }
        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      return vendors;
    }
    /////////////////////////////////////////////////////// Работа с базой данных (БД)
    ///	<summary>
    ///	Метод для создания соединения с сервером.
    /// <para>Используется строка соединения из App.config</para>
    /// <para>return:</para>
    /// <para>System.Data.SqlClient.SqlConnection</para>
    /// </summary>
    private SqlConnection GetSqlConnection()
    {
      String cs = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
      return new SqlConnection(cs);
    }

    private DataTable ReaderToTable(SqlDataReader reader)
    {
      DataTable table = new DataTable();
      try
      {
        int line = 0;

        while (reader.Read())
        {
          if (line == 0)
          {
            for (int i = 0; i < reader.FieldCount; i++)
            {
              table.Columns.Add(reader.GetName(i));
            }
            line++;
          }

          DataRow row = table.NewRow();
          for (int i = 0; i < reader.FieldCount; i++)
          {
            row[i] = reader[i];
          }
          table.Rows.Add(row);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      return table;
    }

    public override string ToString()
    {
      return Name;
    }

  }
}