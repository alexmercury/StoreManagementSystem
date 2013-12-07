using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;

namespace FormFor
{
  public partial class ProductForm : Form
  {
    public Product NewProduct = null;
    private List<Vendor> vendors;
    private List<Category> categories;
    private string ImagePath = String.Empty;
    private bool update = false;

    public ProductForm()
    {
      InitializeComponent();
    }

    public ProductForm(Product update)
    {
      InitializeComponent();
      this.update = true;
      NewProduct = update;
    }

    private void ProductForm_Load(object sender, EventArgs e)
    {
      vendors = Vendor.All();
      categories = Category.All();

      combCategory.DataSource = categories;
      combVendor.DataSource = vendors;

      if (update)
      {
        btnCreate.Text = "Update";
        UpdateLoad();
      }
      else
        btnCreate.Text = "Create";

    }

    private void UpdateLoad()
    {
      tbName.Text = NewProduct.Name;
      rtbSpecification.Text = NewProduct.Specification;
      tbPrice.Text = NewProduct.Price.ToString();
      combVendor.SelectedIndex = vendors.IndexOf(vendors.Where(i => i.ID == NewProduct.Vendor_id).FirstOrDefault());
      combCategory.SelectedIndex = categories.IndexOf(categories.Where(i => i.ID == NewProduct.Category_id).FirstOrDefault());
    }

    private void btnImg_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      if (ofd.ShowDialog() == DialogResult.OK)
      {
        ImagePath = ofd.FileName;
        btnImg.Text = ImagePath;
      }
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
      if (update && Validation())
      {
        this.NewProduct.SetNew(tbName.Text,
                rtbSpecification.Text,
                ImagePath,
                Convert.ToInt32(tbPrice.Text),
                (combVendor.SelectedItem as Vendor).ID,
                (combCategory.SelectedItem as Category).ID
                );
        this.NewProduct.Update(ImagePath != "");
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      else if (Validation())
      {
        NewProduct = Product.Create(tbName.Text,
            rtbSpecification.Text,
            ImagePath,
            Convert.ToInt32(tbPrice.Text),
            (combVendor.SelectedItem as Vendor).ID,
            (combCategory.SelectedItem as Category).ID);
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
    }

    private bool Validation()
    {
      bool result = false;
      int tmp = 0;
      if (tbName.Text.Length > 0
        && (ImagePath != "" || update)
        && rtbSpecification.Text.Length > 0
        && Int32.TryParse(tbPrice.Text, out tmp))
        result = true;
      return result;
    }
  }
}