using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Models
{
  public class Product
  {
    public int ID;
    public string Name;
    public string Specification;
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
    public int Price;
    public int Vendor_id;
    public int Category_id;

    public Product()
    {
      this.ID = 0;
      this.Name = "";
      this.Specification = "";
      this.Price = 0;
      this.Vendor_id = 0;
      this.Category_id = 0;
      this.photo = null;
    }

    public Product(DataRow row)
    {
      this.ID = Convert.ToInt32(row["id"]);
      this.Name = row["name"].ToString();
      this.Specification = row["specification"].ToString();
      this.Price = Convert.ToInt32(row["price"]);
      this.Vendor_id = Convert.ToInt32(row["vendor_id"]);
      this.Category_id = Convert.ToInt32(row["category_id"]);
      this.photo = (byte[])row["photo"];
    }

    public Product(
        string Name,
        string Specification,
        string ImageFilePath,
        int Price,
        int Vendor_id,
        int Category_id
      )
    {
      this.Name = Name;
      this.Specification = Specification;
      this.Price = Price;
      this.Vendor_id = Vendor_id;
      this.Category_id = Category_id;
      this.photo = ImageFileToBytes(ImageFilePath);
    }

    public void SetNew(
       string Name,
       string Specification,
       string ImageFilePath,
       int Price,
       int Vendor_id,
       int Category_id
     )
    {
      this.Name = Name;
      this.Specification = Specification;
      this.Price = Price;
      this.Vendor_id = Vendor_id;
      this.Category_id = Category_id;
      if (ImageFilePath != "")
        this.photo = ImageFileToBytes(ImageFilePath);
    }

    public void Update(bool imgUpdate = false)
    {
      Product oldProduct = Product.FindByID(this.ID);
      List<KeyValuePair<string, string>> updateColunmsParams = new List<KeyValuePair<string, string>>();
      try
      {
        SqlConnection conn = GetSqlConnection();
        conn.Open();

        SqlCommand comm = new SqlCommand();

        if (this.Name != oldProduct.Name)
        {
          comm.Parameters.Add("@p1", SqlDbType.NVarChar, 50).Value = this.Name;
          updateColunmsParams.Add(new KeyValuePair<string, string>("[name]", "@p1"));
        }
        if (this.Specification != oldProduct.Specification)
        {
          comm.Parameters.Add("@p2", SqlDbType.NVarChar, -1).Value = this.Specification;
          updateColunmsParams.Add(new KeyValuePair<string, string>("[specification]", "@p2"));
        }
        if (imgUpdate)
        {
          comm.Parameters.Add("@p3", SqlDbType.Image, this.photo.Length).Value = this.photo;
          updateColunmsParams.Add(new KeyValuePair<string, string>("[photo]", "@p3"));
        }
        if (this.Price != oldProduct.Price)
        {
          comm.Parameters.Add("@p4", SqlDbType.Int).Value = this.Price;
          updateColunmsParams.Add(new KeyValuePair<string, string>("[price]", "@p4"));
        }
        if (this.Vendor_id != oldProduct.Vendor_id)
        {
          comm.Parameters.Add("@p5", SqlDbType.Int).Value = this.Vendor_id;
          updateColunmsParams.Add(new KeyValuePair<string, string>("[vendor_id]", "@p5"));
        }
        if (this.Category_id != oldProduct.Category_id)
        {
          comm.Parameters.Add("@p6", SqlDbType.Int).Value = this.Category_id;
          updateColunmsParams.Add(new KeyValuePair<string, string>("[category_id]", "@p6"));
        }

        String ColumnParams = "";
        foreach (KeyValuePair<string, string> pair in updateColunmsParams)
        {
          ColumnParams += String.Format("{0} = {1},", pair.Key, pair.Value);
        }
        ColumnParams = ColumnParams.TrimEnd(',');

        String query = String.Format("UPDATE [products] SET {0} FROM [products] WHERE [id] = {1};", ColumnParams, this.ID);

        comm.CommandText = query;
        comm.Connection = conn;

        comm.ExecuteNonQuery();
        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public static Product FindByID(int ID)
    {
      Product product = new Product();
      try
      {
        SqlConnection conn = product.GetSqlConnection();
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [products] WHERE [id] = @p1;", conn);
        SqlCommandBuilder cmd = new SqlCommandBuilder(da);
        da.SelectCommand.Parameters.Add("@p1", SqlDbType.Int).Value = ID;
        DataSet set = new DataSet();
        da.Fill(set);

        product = new Product(set.Tables[0].Rows[0]);

        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      return product;
    }

    public void Save()
    {
      try
      {
        SqlConnection conn = GetSqlConnection();
        conn.Open();

        SqlCommand comm = new SqlCommand("INSERT INTO [products] ([name],[specification],[photo],[price],[vendor_id],[category_id]) VALUES (@p1,@p2,@p3,@p4,@p5,@p6);", conn);
        comm.Parameters.Add("@p1", SqlDbType.NVarChar, 50).Value = this.Name;
        comm.Parameters.Add("@p2", SqlDbType.NVarChar, -1).Value = this.Specification;
        comm.Parameters.Add("@p3", SqlDbType.Image, this.photo.Length).Value = this.photo;
        comm.Parameters.Add("@p4", SqlDbType.Int).Value = this.Price;
        comm.Parameters.Add("@p5", SqlDbType.Int).Value = this.Vendor_id;
        comm.Parameters.Add("@p6", SqlDbType.Int).Value = this.Category_id;

        comm.ExecuteNonQuery();
        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void Delete()
    {
      try
      {
        SqlConnection conn = GetSqlConnection();
        conn.Open();
        String query = String.Format("DELETE FROM [products] WHERE [id] = {0};", this.ID);
        SqlCommand comm = new SqlCommand(query, conn);

        comm.ExecuteNonQuery();
        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public static Product Create(
        string Name,
        string Specification,
        string ImageFilePath,
        int Price,
        int Vendor_id,
        int Category_id
     )
    {
      Product product = new Product(Name, Specification, ImageFilePath, Price, Vendor_id, Category_id);
      product.Save();
      return product;
    }

    public static List<Product> All()
    {
      List<Product> products = new List<Product>();
      Product product = new Product();
      try
      {
        SqlConnection conn = product.GetSqlConnection();
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [products];", conn);
        SqlCommandBuilder cmd = new SqlCommandBuilder(da);
        DataSet set = new DataSet();
        da.Fill(set);

        foreach (DataRow row in set.Tables[0].Rows)
        {
          products.Add(new Product(row));
        }

        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      return products;
    }

    public static List<Product> FindByVendor(string vendor)
    {
      List<Product> products = new List<Product>();
      Product product = new Product();
      try
      {
        SqlConnection conn = product.GetSqlConnection();
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [products] WHERE [vendor_id] = (SELECT [id] FROM [vendors] WHERE [name] = @p1);", conn);
        da.SelectCommand.Parameters.Add("@p1", SqlDbType.NVarChar, 50).Value = vendor;
        SqlCommandBuilder cmd = new SqlCommandBuilder(da);
        DataSet set = new DataSet();
        da.Fill(set);

        foreach (DataRow row in set.Tables[0].Rows)
        {
          products.Add(new Product(row));
        }

        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      return products;
    }

    public static List<Product> FindByCategory(string category)
    {
      List<Product> products = new List<Product>();
      Product product = new Product();
      try
      {
        SqlConnection conn = product.GetSqlConnection();
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [products] WHERE [category_id] = (SELECT [id] FROM [categories] WHERE [name] = @p1);", conn);
        da.SelectCommand.Parameters.Add("@p1", SqlDbType.NVarChar, 50).Value = category;
        SqlCommandBuilder cmd = new SqlCommandBuilder(da);
        DataSet set = new DataSet();
        da.Fill(set);

        foreach (DataRow row in set.Tables[0].Rows)
        {
          products.Add(new Product(row));
        }

        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      return products;
    }

    private byte[] ImageFileToBytes(string imageFilePath)
    {
      FileStream fs = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
      byte[] bytes = new byte[fs.Length];
      fs.Read(bytes, 0, (int)fs.Length);
      fs.Close();
      return bytes;
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