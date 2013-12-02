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
        SqlCommand comm = new SqlCommand("INSERT INTO [vendors] ([name]) VALUES (@p1););", conn);
        comm.Parameters.Add("@p3", SqlDbType.NVarChar, 50).Value = this.Name;

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
  }
}