// Меркулов Алексей
// Mercury © 2013 
// SqlManager Version: 1.0.0
// 01.12.2013
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
  /// <summary>
  /// Статический класс для работы с базой данных.
  /// </summary>
  public static class SqlManager
  {
    private static SqlConnection connection = null;
    private static SqlCommand command = null;
    /// <summary>
    /// Готово ли соединение к работе с базой.
    /// </summary>   
    public static bool isReady = false;
    ///	<summary>
    ///	Метод для создания соединения с сервером.
    /// <para>connectionString:</para>
    /// <para>Строка соединения с сервером.</para>
    /// <para>return:</para>
    /// <para>true - соединение успешно,</para>
    /// <para>false - соединение не удалось.</para>
    /// </summary>
    public static bool ConnectToServer(string connectionString)
    {
      try
      {
        connection = new SqlConnection(connectionString);
        connection.Open();
        if (connection.State == ConnectionState.Open)
        {
          isReady = true;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      finally
      {
        connection.Close();
      }
      return isReady;
    }
    ///	<summary>
    ///	Метод для выполнения SQL запроса, который не возвращает данных
    /// <para>sqlQuery:</para>
    /// <para>Текстовая строка запроса</para>
    /// <para>return:</para>
    /// <para>true - запрос выполнен,</para>
    /// <para>false - запрос вернул ошибку.</para>
    /// </summary>
    public static bool ExecuteNonQuery(string sqlQuery)
    {
      bool result = false;
      try
      {
        connection.Open();
        command = new SqlCommand();
        command.CommandText = sqlQuery;
        command.Connection = connection;
        command.ExecuteNonQuery();
        result = true;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      finally
      {
        connection.Close();
      }
      return result;
    }
    ///	<summary>
    ///	Метод для выполнения SELECT запроса в базу данных
    /// <para>selectQuery:</para>
    /// <para>Текстовая строка запроса</para>
    /// <para>return:</para>
    /// <para>Возвращает объект DataTable</para>
    /// </summary>
    public static DataTable Select(string selectQuery)
    {
      DataTable table = new DataTable();
      try
      {
        SqlDataAdapter da = new SqlDataAdapter(selectQuery, connection);
        SqlCommandBuilder cmd = new SqlCommandBuilder(da);
        DataSet set = new DataSet();
        da.Fill(set);
        da.Dispose();
        table = set.Tables[0];
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      return table;
    }
  }
}