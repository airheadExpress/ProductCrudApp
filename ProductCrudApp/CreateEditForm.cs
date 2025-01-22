using ProductCrudApp.Models;
using ProductCrudApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductCrudApp
{
    public partial class CreateEditForm : Form
    {
        public CreateEditForm()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private int productId = 0;

        public void EditProduct(Product product) 
        {
            //Enters the selected information into the CreateEditForm GUI.
            this.Text = "Edit Product";
            this.lblTitle.Text = "Edit Product";

            this.lblID.Text = "" + product.productId;
            this.tbProdName.Text = product.productName;
            this.tbQnty.Text = product.quantityInStock.ToString();
            this.tbPrice.Text = product.price.ToString();

            this.productId = product.productId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Passes the input into product class
            Product product = new Product();
            product.productId = this.productId;
            product.productName = this.tbProdName.Text;
            product.quantityInStock = Convert.ToInt32(this.tbQnty.Text);
            product.price = Convert.ToInt32(this.tbPrice.Text);

            //So that it can be processed by the function over at ProductRepositories.
            var repo = new ProductRepositories();

            //This check determines whether the user intends to create, or update.
            if (product.productId == 0 || product.productId == null)
            {
                repo.CreateProduct(product);
            }
            else 
            {
                repo.UpdateProduct(product);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
