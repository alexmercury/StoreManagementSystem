using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;

namespace Views
{
  public delegate void ViewsEvent(object sender);

  public partial class ProductBox : UserControl
  {
    public Product CurrentProduct = null;
    private bool is_admin = false;
    public event ViewsEvent onDelete;
    public event ViewsEvent onAddShoppingCart;

    public ProductBox(Product product, bool is_admin)
    {
      InitializeComponent();
      CurrentProduct = product;
      this.is_admin = is_admin;
      this.btnDelete.Enabled = false;
    }

    private void ProductBox_Load(object sender, EventArgs e)
    {
      pbPhoto.Image = CurrentProduct.Photo;
      lbName.Text = CurrentProduct.Name;
      rtbContent.Text = CurrentProduct.Specification;
      lbPrice.Text = CurrentProduct.Price.ToString() + " грн";
    }

    private void Delete()
    {
      if (onDelete != null)
        onDelete((object)this);
    }

    private void AddShoppingCart()
    {
      //this.btAddShoppingCart.Enabled = false;
      if (onAddShoppingCart != null)
        onAddShoppingCart((object)this);
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      Delete();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      AddShoppingCart();
    }
    public ProductBox CloneObj()
    {
      ProductBox pb = new ProductBox(CurrentProduct, is_admin);
      pb.btAddShoppingCart.Enabled = false;
      pb.btnDelete.Enabled = true;
      return pb;
    }
  }
}
