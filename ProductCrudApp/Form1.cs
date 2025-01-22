using ProductCrudApp.Repositories;
using System.Data;

namespace ProductCrudApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ReadProducts();
        }

        private void ReadProducts()
        {
            //Draws a table to contain the data that will be taken from the database.
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("productId");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("quantityInStock");
            dataTable.Columns.Add("Price");

            //Calls the info from database for processing.
            var repo = new ProductRepositories();
            var products = repo.GetProducts();
            int tval = repo.GetTotalValue();

            foreach (var product in products)
            {
                //Processes every existing data.
                var row = dataTable.NewRow();

                row["productId"] = product.productId;
                row["Name"] = product.productName;
                row["quantityInStock"] = product.quantityInStock;
                row["Price"] = product.price;

                dataTable.Rows.Add(row);
            }
            //Shows the final output of the process.
            this.productsTable.DataSource = dataTable;
            //This neat little trick saved me the trouble of creating an entirely new GUI.
            if (tval == null || tval == 0)
            {
                this.lbltval.Text = "0";
            }
            else 
            {
                this.lbltval.Text = tval.ToString();
            }
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            //Takes the user to the GUI to add products.
            CreateEditForm form = new CreateEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                //Takes them back to first GUI.
                ReadProducts();
            }
        }

        private void btnEditProd_Click(object sender, EventArgs e)
        {
            //Checks if user input meets criteria for editing.
            var val = this.productsTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int productId = int.Parse(val);

            var repo = new ProductRepositories();
            var product = repo.GetProduct(productId);
            if (product == null) return;

            //Opens up edit screen when user input does meet the criteria.
            CreateEditForm form = new CreateEditForm();
            form.EditProduct(product);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadProducts();
            }
        }

        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            //Checks if there's anything selected.
            var val = this.productsTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int productId = int.Parse(val);

            DialogResult dialogResult =
                MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;

            var repo = new ProductRepositories();
            repo.DeleteProduct(productId);

            ReadProducts();
        }
    }
}
