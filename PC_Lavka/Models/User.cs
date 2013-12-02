// Меркулов Алексей
// Mercury © 2013 
// Models.User Version: 1.0.0
// 02.12.2013
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using SqlManaging;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Models
{
  /// <summary>
  /// Класс описывающий работника предприятия,
  /// <para>а также пользователя программы.</para>
  /// </summary>
  public class User
  {
    /////////////////////////////////////////////////////// Описание всех свойств объекта User
    /// <summary>
    /// Первичный ключ в БД 
    /// </summary>
    public int ID;
    /// <summary>
    /// Идентификатор пользователя,
    /// <para>используется для входа в приложение</para>
    /// </summary>
    public int UID;
    /// <summary>
    /// Пароль для входа в приложение,
    /// <para>Зашифрован в MD5 !!!</para>
    /// </summary>
    public string Password { get; private set; }
    /// <summary>
    /// Фамилия пользователя
    /// </summary>
    public string Surname;
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string Name;
    /// <summary>
    /// Отчество пользователя
    /// </summary>
    public string Patronymic;
    /// <summary>
    /// Картинка в виде массива байтов
    /// </summary>
    private byte[] photo;
    /// <summary>
    /// Картинка в виде объекта Image
    /// </summary>
    public Image Photo
    {
      get
      {
        // Для упрощения работы с byte[] photo
        // Преобразовываем массив байтов в объект Image
        if (photo != null && photo.Length > 0)
        {
          MemoryStream memst = new MemoryStream(photo);
          return Image.FromStream(memst);
        }
        else
          return null;
      }
    }
    /// <summary>
    /// Булево значение, которое указывает на возможность администрирования
    /// </summary>
    public bool is_admin;
    /////////////////////////////////////////////////////// Описание всех конструкторов объекта User
    /// <summary>
    /// Конструктор по умолчанию.
    /// <para>Создает объект пустышку.</para>
    /// </summary>
    public User()
    {
      this.ID = 0;
      this.UID = 0;
      this.Password = "";
      this.Surname = "";
      this.Name = "";
      this.Patronymic = "";
      this.photo = null;
      this.is_admin = false;
    }
    /// <summary>
    /// Создает объект User
    /// <para>из данных объекта System.Data.DataRow ,</para>
    /// <para>который является представлением записи</para>
    /// <para>из таблицы [users] БД</para>
    /// </summary>
    public User(DataRow row)
    {
      this.ID = Convert.ToInt32(row["id"].ToString());
      this.UID = Convert.ToInt32(row["uid"].ToString());
      this.Password = row["password"].ToString();
      this.Surname = row["surname"].ToString();
      this.Name = row["name"].ToString();
      this.Patronymic = row["patronymic"].ToString();
      this.photo = (byte[])row["photo"];
      this.is_admin = Convert.ToBoolean(row["is_admin"].ToString());
    }
    /// <summary>
    /// Создает объект User
    /// <para>инициализируя все его свойства</para>
    /// </summary>
    public User(
        int UID,
        string Password,
        string Surname,
        string Name,
        string Patronymic,
        string ImageFilePath,
        bool is_admin = false
      )
    {
      this.UID = UID;
      this.Surname = Surname;
      this.Password = PasswordMD5(Password);
      this.Name = Name;
      this.Patronymic = Patronymic;
      this.photo = ImageFileToBytes(ImageFilePath);
      this.is_admin = is_admin;
    }
    /// <summary>
    /// Сохраняет объект User в БД , 
    /// <para>в таблицу [users]</para>
    /// </summary>
    public void Save()
    {
      try
      {
        SqlConnection conn = GetSqlConnection();
        conn.Open();
        SqlCommand comm = new SqlCommand("INSERT INTO [users] ([uid],[password],[surname],[name],[patronymic],[photo],[is_admin]) Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7);", conn);
        comm.Parameters.Add("@p1", SqlDbType.Int).Value = this.UID;
        comm.Parameters.Add("@p2", SqlDbType.NVarChar, 255).Value = this.Password;
        comm.Parameters.Add("@p3", SqlDbType.NVarChar, 50).Value = this.Surname;
        comm.Parameters.Add("@p4", SqlDbType.NVarChar, 50).Value = this.Name;
        comm.Parameters.Add("@p5", SqlDbType.NVarChar, 50).Value = this.Patronymic;
        comm.Parameters.Add("@p6", SqlDbType.Image, this.photo.Length).Value = this.photo;
        comm.Parameters.Add("@p7", SqlDbType.Bit).Value = this.is_admin;

        comm.ExecuteNonQuery();
        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public static User FindByUID(int UID)
    {
      User user = new User();
      SqlConnection conn = user.GetSqlConnection();
      conn.Open();
      SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [user] WHERE [uid] = @p1;", conn);
      SqlCommandBuilder cmd = new SqlCommandBuilder(da);
      da.SelectCommand.Parameters.Add("@p1", SqlDbType.Int).Value = UID;
      DataSet set = new DataSet();
      da.Fill(set, "Picture");
      DataTable table = set.Tables[0];

      if (table.Rows.Count > 0)
      {
        user = new User(table.Rows[0]);
      }
      else
        return null;

      return user;
    }

    public static User Create(
        int UID,
        string Password,
        string Surname,
        string Name,
        string Patronymic,
        string ImageFilePath,
        bool is_admin = false
      )
    {
      User user = new User(UID, Password, Surname, Name, Patronymic, ImageFilePath, is_admin);
      user.Save();
      return user;
    }

    public bool VerifyPassword(string Password)
    {
      return (this.Password == PasswordMD5(Password));
    }

    private byte[] ImageFileToBytes(string imageFilePath)
    {
      FileStream fs = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
      byte[] bytes = new byte[fs.Length];
      fs.Read(bytes, 0, (int)fs.Length);
      fs.Close();
      return bytes;
    }

    private string PasswordMD5(string Password)
    {
      return MD5_Hash(MD5_Hash(Password));
    }

    private string MD5_Hash(string text)
    {
      MD5 md5Hash = MD5.Create();

      byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(text));

      StringBuilder str = new StringBuilder();

      for (int i = 0; i < data.Length; i++)
      {
        str.Append(data[i].ToString("x2"));
      }

      return str.ToString();
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