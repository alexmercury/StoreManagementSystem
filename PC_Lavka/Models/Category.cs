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
  public class Category
  {
    public int ID;
    public string Name;
    public string NameRU;

    public Category()
    {
      this.ID = 0;
      this.Name = "";
      this.NameRU = "";
    }

    public Category(DataRow row)
    {
      this.ID = Convert.ToInt32(row["id"]);
      this.Name = row["name"].ToString();
      this.NameRU = row["name_ru"].ToString();
    }

    public Category(string Name, string NameRU)
    {
      this.Name = Name;
      this.NameRU = NameRU;
    }

    public void Save()
    {
      try
      {
        SqlConnection conn = GetSqlConnection();
        conn.Open();
        SqlCommand comm = new SqlCommand("INSERT INTO [categories] ([name],[name_ru]) VALUES (@p1, @p2);", conn);
        comm.Parameters.Add("@p1", SqlDbType.NVarChar, 50).Value = this.Name;
        comm.Parameters.Add("@p2", SqlDbType.NVarChar, 50).Value = this.NameRU;

        comm.ExecuteNonQuery();
        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public static Category Create(string Name, string NameRU)
    {
      Category category = new Category(Name, NameRU);
      category.Save();
      return category;
    }

    public static List<Category> All()
    {
      List<Category> categories = new List<Category>();
      Category category = new Category();
      try
      {
        SqlConnection conn = category.GetSqlConnection();
        conn.Open();
        SqlCommand comm = new SqlCommand("SELECT * FROM [categories];", conn);
        foreach (DataRow row in category.ReaderToTable(comm.ExecuteReader()).Rows)
        {
          categories.Add(new Category(row));
        }
        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      return categories;
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
