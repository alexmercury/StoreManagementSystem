// Меркулов Алексей
// Mercury © 2013 
// FormInstall Version: 1.0.0
// 02.12.2013
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
using SimpleCSV;
using Models;

namespace Install
{
  /// <summary>
  /// Класс формы установки приложения
  /// </summary>
  public partial class FormInstall : Form
  {
    // Строка подключения к базе данных
    private String conn_str = null;
    // Переменная для обработки установки в несколько шагов
    private int step = 0;

    public FormInstall()
    {
      InitializeComponent();
      conn_str = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
      rtbContent.Text = conn_str;
    }

    private void richTextBoxConnStr_TextChanged(object sender, EventArgs e)
    {
      conn_str = rtbContent.Text;// Изменение строки подключения
    }

    // Переход к следующему шагу установки
    private void buttonNext_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      switch (step)
      {
        case 0:// Первый шаг установки
          ConnectionSqlServer();// Создание соединения с сервером
          break;
        case 1:// Второй шаг установки
          CreateTables();// Создание таблиц в базе данных
          break;
        case 2:// Третий шаг установки
          WriteTestData();// Заполнение таблиц тестовыми данными
          break;
        case 3:// Четвертый шаг установки
          FinishInstall();// Завершение установки
          break;
      }
      Cursor = Cursors.Default;
      rtbContent.Cursor = Cursors.Default;
    }

    // Создание соединения с сервером
    private void ConnectionSqlServer()
    {
      if (SqlManager.ConnectToServer(conn_str))
      {
        // Перезаписываем конфигурационный файл
        Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
        config.ConnectionStrings.ConnectionStrings.Remove("ConnStr");
        ConnectionStringSettings connStr = new ConnectionStringSettings("ConnStr", conn_str);
        config.ConnectionStrings.ConnectionStrings.Add(connStr); // Новая строка подключения к базе данных
        config.Save(ConfigurationSaveMode.Minimal);
        // Уведомляем пользователя об успешном соединении с базой данных
        lbHeader.Text = "Соединение установлено !!!";
        lbHeader.ForeColor = Color.Green;
        rtbContent.ReadOnly = true;
        rtbContent.Text = "\nНажмите кнопку 'Далее >>', чтобы начать создание таблиц в базе данных.";
        // Изменяем шаг
        step++;
      }
      else
      {
        // Уведомляем пользователя об неудачном соединении с базой данных
        lbHeader.Text = "Не удалось установить соединение !!!";
        lbHeader.ForeColor = Color.Red;
      }
    }

    // Создание таблиц в базе данных
    private void CreateTables()
    {
      lbHeader.Text = "Создание таблиц:";
      rtbContent.Cursor = Cursors.WaitCursor;
      // Чтение установочных данных из каталога '/data/install'
      // SQL скрипты '/data/install/scripts/*.sql'
      string root_path = @"data\install\scripts\";
      try
      {
        StreamReader file = null;
        // Создание таблицы [users]
        file = new StreamReader(root_path + "users.sql");
        if (SqlManager.ExecuteNonQuery(file.ReadToEnd()))
          rtbContent.Text = "Таблица [users] создана ...\n";
        else
          rtbContent.Text = "При создании таблицы [users] возникли ошибки ...\n";
        file.Dispose();
        // Создание таблицы [vendors]
        file = new StreamReader(root_path + "vendors.sql");
        if (SqlManager.ExecuteNonQuery(file.ReadToEnd()))
          rtbContent.Text += "Таблица [vendors] создана ...\n";
        else
          rtbContent.Text += "При создании таблицы [vendors] возникли ошибки ...\n";
        file.Dispose();
        // Создание таблицы [categories]
        file = new StreamReader(root_path + "categories.sql");
        if (SqlManager.ExecuteNonQuery(file.ReadToEnd()))
          rtbContent.Text += "Таблица [categories] создана ...\n";
        else
          rtbContent.Text += "При создании таблицы [categories] возникли ошибки ...\n";
        file.Dispose();
        // Создание таблицы [products]
        file = new StreamReader(root_path + "products.sql");
        if (SqlManager.ExecuteNonQuery(file.ReadToEnd()))
          rtbContent.Text += "Таблица [products] создана ...\n";
        else
          rtbContent.Text += "При создании таблицы [products] возникли ошибки ...\n";
        file.Dispose();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      rtbContent.Text += "Нажмите кнопку 'Далее >>', чтобы начать заполнять таблицы тестовыми данными...";
      // Изменяем шаг
      step++;
    }

    // Заполнение таблиц тестовыми данными
    private void WriteTestData()
    {
      DataTable tabe = null;
      CSVReader reader = null;

      string root_path = @"data\install\test\";
      try
      {
        lbHeader.Text = "Заполнение данными:";
        rtbContent.Text = "Создание записи администратора...\n";
        User.Create(1000, "admin", "admin", "admin", "admin", root_path + @"users\img\admin.png", true);
        // Создание пользователей
        reader = new CSVReader(root_path + @"users\users.csv");
        tabe = reader.GetDataTable();
        foreach (DataRow row in tabe.Rows)
        {
          rtbContent.Text += "Создание пользователя UID = " + row["uid"].ToString() + " ...\n";
          User.Create(
              Convert.ToInt32(row["uid"].ToString()),
              row["password"].ToString(),
              row["surname"].ToString(),
              row["name"].ToString(),
              row["patronymic"].ToString(),
              root_path + @"users\img\" + row["image_url"].ToString(),
              false
          );
        }
        // Создание производителей (vendor)
        rtbContent.Text += "Создание производителей (vendor)...\n";
        reader = new CSVReader(root_path + @"vendors\vendors.csv");
        tabe = reader.GetDataTable();
        foreach (DataRow row in tabe.Rows)
        {
          Vendor.Create(row["name"].ToString());
        }
        // Создание категорий и товаров
        reader = new CSVReader(root_path + @"categories\categories.csv");
        tabe = reader.GetDataTable();
        foreach (DataRow row in tabe.Rows)
        {
          Category.Create(row["name"].ToString(), row["name"].ToString());
        }

        foreach (Category cat in Category.All())
        {
          string prodpath = root_path + @"products\" + cat.Name.ToLower().Replace(' ', '_');
          reader = new CSVReader(prodpath + @"\products.csv");
          tabe = reader.GetDataTable();
          List<Vendor> vendors = Vendor.All();
          foreach (DataRow row in tabe.Rows)
          {
            int venId = 0;

            foreach (Vendor ven in vendors)
            {
              if (ven.Name == row["vendors"].ToString())
                venId = ven.ID;
            }

            Product.Create(
                row["name"].ToString(),
                row["specification"].ToString(),
                prodpath + @"\img\" + row["image_url"].ToString(),
                Convert.ToInt32(row["price"].ToString()),
                venId,
                cat.ID
            );
          }

        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      rtbContent.Text += "Нажмите кнопку 'Далее >>', чтобы завершить установку...";
      // Изменяем шаг
      step++;
    }

    private void FinishInstall()
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

  }
}